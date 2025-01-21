using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Reload : MonoBehaviour
{
    //allows communication between this code and the ammoDisplay code
    public ammoDisplay AmmoDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if the player hits space bar, apply function 'reload ammo'
        if (Input.GetKey("space"))
        {
            Reloadammo();
            return;
        }
    }

    void Reloadammo()
    {
        // set it manually to 6 since using variables here was giving me problems
        int maxAmmo = 6;
        AmmoDisplay.ammo = maxAmmo;
    }
}
