using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public GameObject page;
    public GameObject page173;
    public GameObject page999;
    public GameObject page049;
    public GameObject page096;
    void OnMouseDown()
    {
        Debug.Log("background");
        page.SetActive(false);
        page173.SetActive(false);
        page999.SetActive(false);
        page049.SetActive(false);
        page096.SetActive(false);
    }
}
