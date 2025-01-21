using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstallMechanic : MonoBehaviour
{
    public bool install = false;
    public float maxInstall = 100f;
    public float installValue;
    public Slider installSlider;
    public Slider easeInstallSlider;
    private float lerpSpeed = 0.05f;
    public HealthBar health;
    [Header("State Colours")]
    [SerializeField] Color idleColour;
    [SerializeField] Color attackColour;
    [SerializeField] Color installColour;
    [SerializeField] Color installAttackColour;
    [SerializeField] Material playerMaterial;
    [SerializeField] MeshRenderer playerRenderer;

    // Start is called before the first frame update
    void Start()
    {
        installValue = 0;
        playerMaterial = new(playerMaterial);
        playerRenderer.material = new (playerMaterial);
    }

    // Update is called once per frame
    void Update()
    {
        SliderCheck();
        ColourSwitch();
  
        if (install)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                playerRenderer.material.SetColor("_Color", installAttackColour);
            }
            DecreaseInstall(20);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                IncreaseInstall(10);
                playerRenderer.material.SetColor("_Color", attackColour);
            }
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (!install && TryGetComponent<Player>(out Player player))
        {
            health.TakeDamage(10);
            Debug.Log("Test");
        }
    }



    private void SliderCheck()
    {
        if (installSlider.value != installValue)
        {
            installSlider.value = Mathf.Lerp(installSlider.value, installValue, lerpSpeed);
        }
    }

    private void ColourSwitch()
    {
        IdleCheck();
        InstallCheck();
        IdleInputs();
        InstallInputs();
    }

    private void IdleCheck()
    {
        if (install && installValue == 0)
        {
            install = false;
            playerRenderer.material.SetColor("_Color", idleColour);
        }
    }

    private void InstallCheck()
    {
        if (!install && installValue == maxInstall)
        {
            install = true;
            playerRenderer.material.SetColor("_Color", installColour);
        }

    }

    private void IdleInputs()
    {
        if (!Input.GetMouseButton(0) && !install)
        {
            playerRenderer.material.SetColor("_Color", idleColour);
        }
    }

    private void InstallInputs()
    {
        if (!Input.GetMouseButton(0) && install)
        {
            playerRenderer.material.SetColor("_Color", installColour);
        }
    }


    void IncreaseInstall (float meterChange)
    {
        installValue += meterChange;
        installValue = Mathf.Min(installValue, maxInstall);
    }

    void DecreaseInstall (float meterChange)
    {
        installValue -= meterChange * Time.deltaTime;
        installValue = Mathf.Max(installValue, 0);
    }
}
