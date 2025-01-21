using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammoDisplay : MonoBehaviour
{
    //public means you can edit the numbers in unity
    public int ammo;
    public int maxAmmo;

    //allows you to drag and drop sprites within unity unity
    public Sprite emptyRound;
    public Sprite fullRound;
    // [] is an array, which allows you to drag and drop multiple gameobjects within unity
    // IMPORTANT: game object must be an IMAGE and not a RAW IMAGE
    public Image[] bullets;

    // bools are true or false statements
    public bool isFiring;

    void Start()
    {
        
    }

    void Update()
    {
        // GetMouseButtonDown(0) is left click, && seems to imply all of the requirements need to be met
        if (Input.GetMouseButtonDown(0) && !isFiring && ammo > 0)
        {
            isFiring = true;
            // -- subtracts a bullet from the counter
            ammo--;
            isFiring = false;
        }

        //a for statement is a loop, though I know little more than that
        for (int i = 0; i < bullets.Length; i++)
        {
            // if ammo is above 0, displays bullet, otherwise it displays empty round
            if (i < ammo)
            {
                bullets[i].sprite = fullRound;
            }
            else
            {
                bullets[i].sprite = emptyRound;
            }
            
            // I thiiiink this is to do with the bullets stored in the array?
            if (i < maxAmmo)
            {
                bullets[i].enabled = true;
            }
            else 
            {
                bullets[i].enabled = false;
            }
        }
    }
}
