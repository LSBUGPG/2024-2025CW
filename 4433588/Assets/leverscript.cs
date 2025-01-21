using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverscript : MonoBehaviour
{
    public bool lever = true;
    public shutter Shutter;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Debug.Log("lever");
        Shutter.Waiting = false;
    }
}