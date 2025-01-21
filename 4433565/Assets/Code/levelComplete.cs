using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{

    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Vector3.Distance(this.transform.position, Camera.transform.position) < 3)
        { 
            SceneManager.LoadScene("Stat Screen");
        }
    }
}
