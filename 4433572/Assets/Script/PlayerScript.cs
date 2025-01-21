using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    public float dashSpeed;
    private float originalSpeed;
    public float cameraSpeed;
    public float hoverSpeed;
    public float hoverFloat;
    public bool hoverActive;
    public Transform pAttackSpawn;
    public float pAttackSpeed;
    public GameObject pAttack;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        originalSpeed = speed;
        dashSpeed = speed * 2;
        hoverActive = false;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hoverActive == false)
        {
            float input = Input.GetAxis("Horizontal");
            transform.Translate(input * speed * Vector3.right * Time.deltaTime);

            float input2 = Input.GetAxis("Vertical");
            transform.Translate(input2 * speed * Vector3.forward * Time.deltaTime);

            float mouseLocation = Input.GetAxis("Mouse X");
            transform.Rotate(new Vector3(0,mouseLocation,0) * Time.deltaTime * cameraSpeed);
        }

        if(hoverActive == true)
        {
            if(Input.GetKey(KeyCode.Q))
            {
                transform.Translate(hoverFloat * Vector3.up * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.E))
            {
                transform.Translate(hoverFloat * Vector3.down * Time.deltaTime);
            }
            float input = Input.GetAxis("Horizontal");
            transform.Translate(input * hoverSpeed * Vector3.right * Time.deltaTime);

            float input2 = Input.GetAxis("Vertical");
            transform.Translate(input2 * hoverSpeed * Vector3.forward * Time.deltaTime);

            float mouseLocation = Input.GetAxis("Mouse X");
            transform.Rotate(new Vector3(0, mouseLocation, 0) * Time.deltaTime * cameraSpeed);
        }
        if(Input.GetKey(KeyCode.F))
        {
            speed = dashSpeed;
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            speed = originalSpeed;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            var attack = Instantiate(pAttack,pAttackSpawn.position, pAttackSpawn.rotation);
            attack.GetComponent<Rigidbody>().velocity = pAttackSpawn.forward * pAttackSpeed;
        }
        //this is where i got reference for some part of the code:
        //https://www.youtube.com/watch?v=6Ai0xg6xTUk
        //https://github.com/LSBUGPG/movement-tutorial?tab=readme-ov-file
    }
}
