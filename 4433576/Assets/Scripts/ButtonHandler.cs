using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{

    public UI_Handler uiHandler;

    // Index of selected panel
    public int Panel;
    
    void Start()
    {
        // UI starts closed
        uiHandler.ClosePanels();
    }

    public void OnClick()
    {
        uiHandler.ChangePanel(Panel);
    }

}



