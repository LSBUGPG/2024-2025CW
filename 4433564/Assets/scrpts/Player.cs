using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    Vector3 mouseworldpos;
    public int maxLives;
    public AudioSource audioSource;
    public Slider slider;
    int health = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health == 0)
        {
            return;
        }
        
      if (Input.GetMouseButton(0))
        {
            mouseworldpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseworldpos.z = 0;
        }
        Vector3 target = mouseworldpos - transform.position;
        rb.velocity = target * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="enemy")
        {
            maxLives -= 1;
            health -= 1;
            slider.value = health;
            Destroy(collision.gameObject); 
            audioSource.Play();
        }
    }
}
