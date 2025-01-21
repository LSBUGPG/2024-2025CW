using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class NPCSystem : MonoBehaviour
{
    public GameObject d_template;
    public GameObject canva;
    bool player_detection = false;

    // Update is called once per frame
    void Update()
    {
        //this means that if the player is detected by the sphere through the tag, and the key "f" is pressed while in the radius that the command will be completed.
        //the print will not be visible on screen but in the consle if successful. If worked this means that the interactable element of the dialouge ssystem works.
        if (player_detection && Input.GetKeyDown(KeyCode.F))
        {
            canva.SetActive(true);
            PlayerMovement.dialouge = true;
            NewDialouge("HI");
            canva.transform.GetChild(0).gameObject.SetActive(true);

        }

    }

    void NewDialouge(string text)
    {
        GameObject template_clone = Instantiate(d_template, canva.transform);
        //template_clone.transform.parent = canva.transform;
        template_clone.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = text;
    }

    
    // Private means that it cannot be accessed in unity and the inspector, the OnTrigger means that when a mesh touches or collides with it that the comman in the bracket will occur.
    // the other means that the type of collider does not matter e.g. capsule or sphere collider.
    //The name "Player" refers to the tag that is applied onto an object this means that of the tag detected the command will not occur unless it is "Player"
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            player_detection = true;
        }
    }

    //this means that if the collider is not the player that the next commmand for the dialouge will not occur
    private void OnTriggerExit(Collider other)
    {
        player_detection = false;
    }
}
