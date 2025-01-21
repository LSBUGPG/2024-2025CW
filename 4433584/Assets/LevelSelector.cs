using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenScene(string name)
    {
        Debug.Log("Level load requested for: " + name);

        SceneManager.LoadScene(name);
    }
}
