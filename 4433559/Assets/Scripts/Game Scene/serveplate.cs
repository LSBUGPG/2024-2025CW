using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class serveplate : MonoBehaviour
{
    List<Transform> food = new List<Transform>();

    public void AddFood(Transform item)
    {
        food.Add(item);
    }

    public void ClearPlate()
    {
        clickplace.Reset();
        foreach (Transform item in food)
        {
            Destroy(item.gameObject);
        }
        food.Clear();
        gameflow.plateValue = 0;
    }

    private void OnMouseDown()
    {
        clickplace.Reset();
        if (gameflow.orderValue==gameflow.plateValue)
        {
            gameflow.plateValue = 000000;
            SceneManager.LoadSceneAsync("WinScreen");
        }

        else
        {
            gameflow.plateValue = 000000;
            SceneManager.LoadSceneAsync("LoseScreen");
        }
    }
}
