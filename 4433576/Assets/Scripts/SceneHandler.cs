using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Make use of the SceneManager api
using UnityEngine.SceneManagement;


public class SceneHandler : MonoBehaviour
{

    // Name of Scene to be loaded on button press
    public string NewScene;

    public void ChangeScene()
    {
        SceneManager.LoadScene(NewScene);
    }


}
