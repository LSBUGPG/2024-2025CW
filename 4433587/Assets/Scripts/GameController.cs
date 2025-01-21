using UnityEngine;
using TMPro;


public class GameController : MonoBehaviour
{

    public TextMeshProUGUI scoreTextLeft;
    public TextMeshProUGUI scoreTextRight;

    private int scoreLeft = 0;
    private int scoreRight = 0;

    public GameObject ball;
    void Start()
    { 
        
    }

    
    void Update()
    {
       
    }

    public void ScoreGoalLeft () 
    {
        Debug.Log("ScoreGoalLeft");
        scoreRight += 1;
        UpdateUI();
        Invoke("SpawnBall", 0.5f);
    }

    public void ScoreGoalRight ()
    {
         Debug.Log("ScoreGoalRight");
         scoreLeft += 1;
        UpdateUI();
        Invoke("SpawnBall", 0.5f);
    }

    private void UpdateUI()
    {
    scoreTextLeft.text = scoreLeft.ToString();
    scoreTextRight.text = scoreRight.ToString();
    }

    private void SpawnBall()
    {
        Instantiate(ball,ball.transform.position,Quaternion.identity);
    }
}

