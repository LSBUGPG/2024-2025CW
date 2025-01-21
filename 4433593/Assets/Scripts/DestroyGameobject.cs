using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameobject : MonoBehaviour
{
    [SerializeField] float DestroySpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroySpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
