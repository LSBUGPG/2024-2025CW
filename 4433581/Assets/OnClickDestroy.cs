using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickDestroy : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
