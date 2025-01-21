using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCount : MonoBehaviour
{
    public Rigidbody body;
    public float force = 2;
    public TMP_Text text;

    int coins = 0;
    public void AddCoin()
    {
        coins++;
        Debug.Log($"Coins collected: {coins}");
        text.text = "Coins collected " + coins;
       
    }
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Coins collected " + coins;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            body.AddForce(Vector3.right * force, ForceMode.Impulse);
        }
        
       
    }
}
