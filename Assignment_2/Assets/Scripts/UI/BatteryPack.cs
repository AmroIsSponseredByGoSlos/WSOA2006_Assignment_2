using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPack : MonoBehaviour
{
    [SerializeField] private FlashlightController _flashlightController;
    void AddTime()
    {
        if (_flashlightController.LightTime < 30 && _flashlightController.LightTime >= 0)
        {
            _flashlightController.LightTime += 10;
            if (_flashlightController.LightTime >= 30)
            {
                _flashlightController.LightTime = 30;
            }
        }
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AddTime();
        }
    }
}
