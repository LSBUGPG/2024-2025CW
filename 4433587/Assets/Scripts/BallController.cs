using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;

    private Vector3 direction;
    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ChooseDirection();
    }

    void Update()
    {    
        transform.position += direction * speed * Time.deltaTime; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            direction.x = -direction.x;
        }

        if (other.CompareTag("Racket"))
        {
            direction.z = -direction.z;
        }


    }
    private void ChooseDirection() 
    { 
        float signX = Mathf.Sign(Random.Range(-1f, 1f));
        float signZ = Mathf.Sign(Random.Range(-1f, 1f));

        direction = new Vector3(0.5f* signX, 0, 0.5f* signZ);
    }
   
}
