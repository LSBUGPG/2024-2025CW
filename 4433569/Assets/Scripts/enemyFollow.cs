using UnityEditor.Timeline;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public float enemySpeed = 4f;
    public Transform target;
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, enemySpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
{
    if(collision.gameObject.name == "Player")
    {
        Destroy(collision.gameObject);
    }
}

}
