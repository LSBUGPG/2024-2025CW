using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallpage : MonoBehaviour
{
    public GameObject page;

    private void Start()
    {
        page.SetActive(false);
    }

    void OnMouseDown()
    {
        page.SetActive(true);
    }
}