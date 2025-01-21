using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reject : MonoBehaviour
{
    public Character character;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Debug.Log("reject");
        character.Waiting = false;
}
}
