using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickplace : MonoBehaviour
{
    //this code is from https://www.youtube.com/watch?v=WGGAckunBcQ
    public serveplate plate;

    public int foodValue;
    static float offset = 0;
    //

    public static void Reset()
    {
        offset = 0;
    }
    
    private void OnMouseDown()
    {
        Transform clone = Instantiate(transform);
        plate.AddFood(clone);
        clone.localScale = Vector3.one * 0.5f;
        clone.localPosition = new Vector3(4, 3 + offset, - offset);
        Debug.Log("cloned");
        offset += 0.1f;

        gameflow.plateValue += foodValue;
    }
}
