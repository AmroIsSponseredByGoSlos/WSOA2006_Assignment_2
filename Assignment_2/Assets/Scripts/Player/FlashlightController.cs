using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    public float LightTime;
    public bool isOn;
   [SerializeField]private GameObject Flashlight;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ActivateLight();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            DeactivateLight();   
        }
        DecreaseLightTime();
    }

    private void ActivateLight()
    {
        if (!isOn)
        {
            isOn = true;
            Flashlight.SetActive(true);
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
        if (isOn )
        {
            LightTime -= Time.deltaTime;
        }
    }
}
