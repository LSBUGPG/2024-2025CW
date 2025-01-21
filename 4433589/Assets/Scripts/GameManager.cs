using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } // Turns this object into a singleton.

    private int _score;
    [SerializeField] private TextMeshProUGUI scoreText;

    [SerializeField] private Transform[] ballPrefabs; // List of all the balls that can be used in the game.
    [SerializeField] private Texture2D[] ballImages;
    private int[] _ballsToSpawn = new int[] { 0, 0 };
    [SerializeField] private RawImage nextBall;
    public Vector3 mouseXPos; // Will store the position of the mouses x coords in gamespace.

    [Header("Ball Properties")] public Vector3 ballSpawnLocation; // Defines where the ball will spawn.
    [SerializeField] private float ballYSpawn;

    private bool _spawning = default; // Determines whether there is a ball in the process of spawning or not.

    private void Awake()
    {
        // Makes sure this is the only instance of this script.
        if (Instance != null && Instance != this) Destroy(this);
        else Instance = this;
    }

    private void Start()
    {
        // Instantiate the first ball to be dropped
        Instantiate(ballPrefabs[0], ballSpawnLocation, Quaternion.identity);
    }

    private void Update() // Every update 
    {
        mouseXPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Get the mouses x position
        ballSpawnLocation =
            new Vector3(mouseXPos.x, 4.0f,
                1.0f); // Change the spawn location of the ball based on the mouses x position.

        if (Input.GetMouseButtonDown(0) && !_spawning)
        {
            _ballsToSpawn[0] = _ballsToSpawn[1];
            _ballsToSpawn[1] = Random.Range(0, 4);
            nextBall.texture = ballImages[_ballsToSpawn[1]];
            StartCoroutine(SpawnBall(0.8f,
                _ballsToSpawn[0])); // If the player clicks then spawn a new ball to be dropped.
        }
    }

    private IEnumerator SpawnBall(float spawnTime, int ballToSpawn) // This is called when a new ball to be dropped needs spawning.
    {
        if (_spawning) yield break; // If already spawning then break

        _spawning = true; // Ball is spawning

        yield return new WaitForSeconds(spawnTime); // Wait set time period
        Instantiate(ballPrefabs[ballToSpawn], ballSpawnLocation, Quaternion.identity); // Spawn the ball

        _spawning = false; // Ball is no longer spawning
    }
    
    // Ball Merging
    public void TryMerge(GameObject fruit1, GameObject fruit2)
    {
        MergeProperties fruitComponent1 = fruit1.GetComponent<MergeProperties>();
        MergeProperties fruitComponent2 = fruit2.GetComponent<MergeProperties>();
        
        if (fruitComponent1.size == fruitComponent2.size && !fruitComponent1.isMerging && !fruitComponent2.isMerging)
        {
            StartCoroutine(MergeFruits(fruit1, fruit2, fruitComponent1));
        }
    }
    
    IEnumerator MergeFruits(GameObject fruit1, GameObject fruit2, MergeProperties fruitComponent)
    {
        fruit1.GetComponent<MergeProperties>().isMerging = true;
        fruit2.GetComponent<MergeProperties>().isMerging = true;
    
        // Gets the velocity of the two balls
        var rb1 = fruit1.GetComponent<Rigidbody2D>();
        var rb2 = fruit2.GetComponent<Rigidbody2D>();
        Vector3 newVelocity = (rb1.mass * rb1.velocity + rb2.mass * rb2.velocity) / (rb1.mass + rb2.mass);
        
        // Gets the midway point between the two balls to spawn
        Vector3 spawnPosition = (fruit1.transform.position + fruit2.transform.position) / 2;

        yield return new WaitForSeconds(0.1f);
        
        // Instantiate the larger fruit and destroys the smaller ones
        Transform largerFruit = ballPrefabs[fruitComponent.size+1];
        Destroy(fruit1);
        Destroy(fruit2);
        
        var newMerge = Instantiate(largerFruit, spawnPosition, Quaternion.identity);
        newMerge.GetComponent<Rigidbody2D>().velocity = newVelocity;
        
        // Adds score
        _score += fruitComponent.score;
        scoreText.text = _score.ToString();
    }
}