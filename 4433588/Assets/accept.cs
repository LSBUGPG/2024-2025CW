using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accept : MonoBehaviour
{
    public SpriteRenderer gameover;
    
    void Start()
    {
        gameover.enabled = false;
    }
    void OnMouseDown()
    {
        gameover.enabled = true;
    }
}
