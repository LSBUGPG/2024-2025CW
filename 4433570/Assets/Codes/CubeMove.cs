using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.Translate(inputX * Time.deltaTime * speed * Vector3.right);

        float inputY = Input.GetAxis("Vertical");
        transform.Translate(inputY * Time.deltaTime * speed * Vector3.up);
        

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            transform.Translate(new Vector3(0,0,-1) * Time.deltaTime * speed);
        }
      
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        }
    }
}
