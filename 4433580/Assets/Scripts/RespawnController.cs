using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnController : MonoBehaviour
{
    public static RespawnController instance;

    public Vector3 respawnPoint;
    public float waitToRespawn;

    public GameObject thePlayer;

    public void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }
    void Start()
    {
        thePlayer = HealthController.instance.gameObject;

        respawnPoint = transform.position;
    }

    // Update is called once per frame
    public void SetRespawn(Vector3 pos)
    {
        respawnPoint = pos;
    }

    public void RespawnPlayer()
    {
        StartCoroutine(RespawnCo());
    }

    IEnumerator RespawnCo()
    {
        thePlayer.SetActive(false);

        yield return new WaitForSeconds(waitToRespawn);

        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        thePlayer.transform.position = respawnPoint;
        thePlayer.SetActive(true);


    }
}

