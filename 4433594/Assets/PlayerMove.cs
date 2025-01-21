using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void AddGem()
    {
        gems++;
        Debug.Log($"Gems Collected: {gems}");

    }
    int gems;
    // Update is called once per frame
    void Update()
    {
        float input = UnityEngine.Input.GetAxis("Horizontal");
        transform.Translate(Time.deltaTime * input * speed * Vector3.right);

        float press = UnityEngine.Input.GetAxis("Vertical");
        transform.Translate(Time.deltaTime * press * speed * Vector3.up);
    }
}
