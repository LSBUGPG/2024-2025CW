using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Handler : MonoBehaviour
{

    // Table of UI Panels
    public GameObject[] Panels;

    public GameObject ButtonsPanel;

    public void ChangePanel(int PanelIndex)
    {

        // Check if any UI panel is active and creates toggle bool
        bool isActive = Panels[PanelIndex].activeSelf;

        // Close all UI panels
        for (int i = 0; i < Panels.Length; i++)
        {
            Panels[i].SetActive(false);
        }

        // Toggles selected UI panel using bool var (if already open, closes it, vice versa)
        Panels[PanelIndex].SetActive(!isActive);
        ButtonsPanel.SetActive(!isActive);

    }

    public void ClosePanels()
    {
        for (int i = 0; i < Panels.Length; i++)
        {
            Panels[i].SetActive(false);
        }

        ButtonsPanel.SetActive(false);
    }

}



