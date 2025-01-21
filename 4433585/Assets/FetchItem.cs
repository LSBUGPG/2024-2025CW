using UnityEngine;
using TMPro;
using System.Collections;

public class FetchItem : MonoBehaviour
{
    public TextMeshProUGUI questMessage;
    private bool playerInRange = false;
    private bool isCollected = false;
    public NPCQuest npcQuest;


    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && !isCollected && npcQuest.IsQuestAccepted())

        {
            isCollected = true;


            Renderer[] renderers = GetComponentsInChildren<Renderer>();
            foreach (Renderer renderer in renderers)
            {
                renderer.enabled = false;  // Hide the mesh renderer
            }

            Collider[] colliders = GetComponentsInChildren<Collider>();
            foreach (Collider collider in colliders)
            {
                collider.enabled = false;  // Disable the collider so player can't interact anymore
            }


            DisplayMessage("Item collected! Now return to NPC.");

            if (npcQuest != null)
            {
                npcQuest.MarkQuestComplete();

            }

            StartCoroutine(ClearMessageAfterDelay(2.4f));
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isCollected)
        {
            playerInRange = true;

            if (npcQuest.IsQuestAccepted())

            DisplayMessage("Press 'E' to pickup.");


        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && !isCollected)
        {

            playerInRange = false;

            ClearQuestMessage();
        }

    }

    private void DisplayMessage(string message)
    {
        if (questMessage != null)

        {
            questMessage.text = message;

        }

    }

    private void ClearQuestMessage()
    {
        if (questMessage != null)
        {
            questMessage.text = "";

        }


    }

    private IEnumerator ClearMessageAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        ClearQuestMessage();
    }

}
