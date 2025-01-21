using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public int maxHP = 10;
    public int HP;
    public int score = 0;
    private int scoreToAdd;

    public GameObject healthUI;
    public GameObject scoreUI;
    public TMP_Text healthCounter;
    public TMP_Text scoreCounter;

    public GameObject diffUI;
    public TMP_Text diffCounter;
    public GameObject diffRefObj;
    private BulletSpawn diffRef;
    // Start is called before the first frame update
    void Start()
    {
        HP = maxHP;
        healthCounter = healthUI.GetComponent<TextMeshProUGUI>();
        scoreCounter = scoreUI.GetComponent<TextMeshProUGUI>();
        healthCounter.text = "Health: " + HP;
        scoreCounter.text = "Score: " + score;
        diffCounter = diffUI.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        diffRef = diffRefObj.GetComponent<BulletSpawn>();
        diffCounter.text = "Difficulty Lvl: " + diffRef.diffLevel;
    }

    private void OnTriggerEnter2D(Collider2D contact)
    {
        if (contact.gameObject.CompareTag("Damage"))
        {
            if (HP > 0)
            {
                HP -= 1;
                healthCounter.text = "Health: " + HP;
                if (HP == 0)
                {
                    GameObject.Destroy(gameObject);
                }
                GameObject.Destroy(contact.gameObject);
            }
        }
        
        if (contact.gameObject.CompareTag("Heal"))
        {
            if (HP < maxHP)
            {
                HP += 1;
                healthCounter.text = "Health: " + HP;
                GameObject.Destroy(contact.gameObject);
            }


        }

        if (contact.gameObject.CompareTag("Score"))
        {
            scoreToAdd = contact.gameObject.GetComponent<ScoreID>().scoreAwarded;
            score = score + scoreToAdd;
            scoreCounter.text = "Score: " + score;
            GameObject.Destroy(contact.gameObject);
        }
    }
}
