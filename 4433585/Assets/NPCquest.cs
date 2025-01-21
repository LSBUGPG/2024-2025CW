using UnityEngine;
using TMPro; // Include this to use TextMeshPro

public class NPCQuest : MonoBehaviour
{
    private bool playerInRange = false;
    private bool questAccepted = false;
    private bool questComplete = false;
    public TextMeshProUGUI questMessage; // UI for NPC quest messages
    public TextMeshProUGUI questTracker; // UI for quest tracker in the top left

    public bool IsQuestAccepted()
    {
        return questAccepted;
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (!questAccepted)
            {
                // Accept the quest
                questAccepted = true;
                DisplayMessage("Quest Accepted: Please fetch the item!");
                SetQuestTracker("Current Quest: Fetch the item. It is located outside in an opening.");
            }
            else if (questAccepted && questComplete)
            {
                // Complete the quest
                DisplayMessage("Quest Complete: You returned the item!");
                SetQuestTracker("\"Thank you traveller!\"");
                questAccepted = false; // Disable future interactions

                Invoke("ClearMessage", 2f);
                Invoke("ClearQuestTracker", 3f);


            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;

            if (questComplete)
            {
                DisplayMessage("Press 'E' to complete the quest.");
                SetQuestTracker("");
            }
            else if (!questAccepted)
            {
                DisplayMessage("Press 'E' to accept the quest.");
                SetQuestTracker("\"Hello traveller! Would you mind finding an Item I have lost somewhere outside?\"");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;

            if (!questComplete)
            {
                ClearMessage();
            }
        }
    }



   


public void MarkQuestComplete()

    {
        questComplete = true;
        SetQuestTracker("Current Quest: Item collected! Return to the NPC to finish your quest.");
    }



    private void DisplayMessage(string message)
    {
        if (questMessage != null)
        {
            questMessage.text = message;
        }
    }

    private void ClearMessage()
    {
        if (questMessage != null)
        {
            questMessage.text = "";
        }
    }

    private void SetQuestTracker(string message)
    {
        if (questTracker != null)
        {
            questTracker.text = message;
        }
    }


    private void ClearQuestTracker()
    {
        if (questTracker != null)
        {
            questTracker.text = "";
        }
    }
}