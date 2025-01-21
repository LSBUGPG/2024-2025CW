using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float speed = 5;

    public float mousespeed = 5;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal * speed * Time.deltaTime * Vector3.right);
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(vertical * speed * Time.deltaTime * Vector3.forward);
        float horizontalmouse = Input.GetAxis("Mouse X");
        transform.Rotate(horizontalmouse * mousespeed * Time.deltaTime * Vector3.up);
    }
}
