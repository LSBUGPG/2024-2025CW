using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <-6)
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        //Destroy(gameObject);
        anim.SetBool("cut", true);
    }
}
