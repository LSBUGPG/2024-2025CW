using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void options()
    {
        Debug.Log("options");
    }

    public void exit()
    {
#if UNITY_EDITOR
         EditorApplication.ExitPlaymode();
#else 
        Application.Quit();
#endif
    }


    
}
