using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealtScript : MonoBehaviour
{
    public int playerMaxHealth;
    public int playerCurrentHealth;
    public Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
        healthText = GameObject.Find("PlayerHealth").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.GetComponent<Text>().text = playerCurrentHealth.ToString();
        if(playerCurrentHealth == 0)
        {
            RestartScene();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            playerCurrentHealth -= 1;
        }
    }
    public void RestartScene()
    {
        Scene PrototypeLevel = SceneManager.GetActiveScene();
        SceneManager.LoadScene(PrototypeLevel.name);
    }
}
// I used a bit of code from this video: https://www.youtube.com/watch?v=vNL4WYgvwd8