using System.Collections;
using UnityEngine;

public class CatManager : MonoBehaviour
{
    private GameManager _gameManager;
    
    [Header("Blinking Cat")]
    [SerializeField] private Sprite catEyeOpen; 
    [SerializeField] private Sprite catEyeClosed; 
    
    [SerializeField] private float minBlinkDuration = 0.25f;
    [SerializeField] private float maxBlinkDuration = 0.5f; 
    [SerializeField] private float minTimeBetweenBlinks = 2.0f; 
    [SerializeField] private float maxTimeBetweenBlinks = 6.0f; 

    private SpriteRenderer _spriteRenderer;
    private bool _isBlinking;
    
    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.sprite = catEyeOpen; 
        
        InvokeRepeating(nameof(Blink), GetRandomBlinkTime(), GetRandomBlinkTime()); 
    }
    
    private void Blink()
    {
        StartCoroutine(BlinkCoroutine());
    }

    private IEnumerator BlinkCoroutine()
    {
        if (_isBlinking) yield break;

        _isBlinking = true;
        _spriteRenderer.sprite = catEyeClosed;
        
        float blinkDuration = Random.Range(minBlinkDuration, maxBlinkDuration);
        yield return new WaitForSeconds(blinkDuration); 

        _spriteRenderer.sprite = catEyeOpen; 
        _isBlinking = false;
        
        float nextBlinkTime = GetRandomBlinkTime();
        Invoke(nameof(Blink), nextBlinkTime);
    }
    
    private float GetRandomBlinkTime()
    {
        return Random.Range(minTimeBetweenBlinks, maxTimeBetweenBlinks);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Merge"))
        {
            _gameManager.TryMerge(gameObject, collision.gameObject);
        }
    }
}