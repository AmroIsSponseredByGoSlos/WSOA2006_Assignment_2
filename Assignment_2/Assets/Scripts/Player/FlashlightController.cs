using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashlightController : MonoBehaviour
{
    public int LightTime;
    private float countdownInterval = 1f; // Update timer every one second
    private float countdownTimer = 0f; // Update timer every one second
    public PlayerController playerController;
    public bool isOn;
    
   [SerializeField]private GameObject Flashlight;
   [SerializeField]private GameObject BatteryText;
   [SerializeField]private Text _BatteryText;

    private void Update()
    {
        countdownTimer += Time.deltaTime;
        
        if (countdownTimer >= countdownInterval)
        {
            countdownTimer -= countdownInterval;
            DecreaseLightTime();
        }
        
        if (Input.GetButtonDown("Fire1") && playerController.HoldingCrate == false)
        {
            ActivateLight();
        }

        if (Input.GetButtonDown("Fire2") && playerController.HoldingCrate == false)
        {
            DeactivateLight();   
        }


        if (LightTime == 0)
        {
            BatteryText.SetActive(true);
            _BatteryText.text = "No Battery left !!";
        }
        if (LightTime > 2)
        {
            BatteryText.SetActive(false);
            _BatteryText.text = "Battery Low !!!";
        }
    }

    private void ActivateLight()
    {
        if (!isOn)
        {
            isOn = true;
            Flashlight.SetActive(true);
            DecreaseLightTime();
        }
    }
    private void DeactivateLight()
    {
        if (isOn)
        {
            isOn = false;
            Flashlight.SetActive(false);
        }
    }
    private void DecreaseLightTime()
    {
        if (isOn && LightTime > 0)
        {
            LightTime -= 1;
        }
        else if (isOn && LightTime <= 0)
        {
            isOn = false;
            Flashlight.SetActive(false);
        }

        if (isOn && LightTime == 2)
        {
            BatteryText.SetActive(true);
        }

    }
}

