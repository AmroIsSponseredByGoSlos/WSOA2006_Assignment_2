using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public int maximum;
    public FlashlightController _FlashlightController;
    public Image FlashLightMask;


    void Update()
    {
        GetCurrentFill(FlashLightMask, _FlashlightController.LightTime);
    }

    void GetCurrentFill(Image mask, float attributeValue)
    {
        float fillAmount = attributeValue / maximum;
        mask.fillAmount = fillAmount;
    }
}
