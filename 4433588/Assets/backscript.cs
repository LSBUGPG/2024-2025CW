using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backscript : MonoBehaviour
{
    public GameObject pageToReturnTo;
    public GameObject page;
    public GameObject page049;
    public GameObject page096;
    public GameObject page173;
    public GameObject page999;
    void OnMouseDown()
    {
        pageToReturnTo.SetActive(true);
        page.SetActive(false);
    }
    void Start()
    {
        page049.SetActive(false);
        page096.SetActive(false);
        page173.SetActive(false);
        page999.SetActive(false);
    }
}
