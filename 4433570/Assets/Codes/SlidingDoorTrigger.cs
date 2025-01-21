using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoorTrigger : MonoBehaviour
{
    public Animator MyAnim;
    public string PlayerTag;
    public string OpenCloseAnimBoolName;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == PlayerTag)
        {
            MyAnim.SetBool(OpenCloseAnimBoolName, true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == PlayerTag)
        {
            MyAnim.SetBool(OpenCloseAnimBoolName, false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
