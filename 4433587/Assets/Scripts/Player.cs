using UnityEngine;
using Input = UnityEngine.Input;

public class Player : MonoBehaviour


{
    public bool isPlayer = true;
    public float speed = 10;
    private Transform ballTransform;

    void Start()
    {
      
    }

    void Update()
    {
        GameObject ball = GameObject.FindGameObjectWithTag("Ball");
        if (ball == null) return;

        ballTransform = ball.transform;
        if (isPlayer)
        {
            MoveByPlayer();
        }
        else
        {
            MoveByComputer();

        }
    }

    private void MoveByPlayer()
    {
        float input = Input.GetAxis("Horizontal");
        transform.Translate(input * speed * Time.deltaTime * Vector3.right);
    }

    private void MoveByComputer()
    {
        if (ballTransform.position.x > transform.position.x)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.right);
        }
        else if (ballTransform.position.x < transform.position.x)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
    }
}

