using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public PlayerController playerController;
    public FlashlightController flashlightController;
    public bool Subtracted = false;
    public bool FlagReset = false;

    void Update()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        Scene ActiveScene = SceneManager.GetActiveScene();
        if (ActiveScene.name == "Level1" && !FlagReset)
        {
            playerController.FlagCount = 1;
            FlagReset = true;
        }
        if (ActiveScene.name == "Level2" && !FlagReset)
        {
            playerController.FlagCount = 2;
            FlagReset = true;
        }
        if (ActiveScene.name == "Level3" && !FlagReset)
        {
            playerController.FlagCount = 2;
            FlagReset = true;
        }
        if (ActiveScene.name == "Level4" && !FlagReset)
        {
            playerController.FlagCount = 0;
            FlagReset = true;
        }
        if (ActiveScene.name == "Level5" && !FlagReset)
        {
            playerController.FlagCount = 4;
            FlagReset = true;
        }
        if (ActiveScene.name == "Level4" && !Subtracted)
        {
            flashlightController.LightTime = 0;
            Subtracted = true;
        }
    }

    public void LoadLevel1()
    {
        StartCoroutine(LoadLevelWithDelay("Level1", 1)); // 3 seconds delay
    }

    public void LoadLevel2()
    {
        StartCoroutine(LoadLevelWithDelay("Level2", 3f)); // 3 seconds delay
    }

    public void LoadLevel3()
    {
        StartCoroutine(LoadLevelWithDelay("Level3", 3f)); // 3 seconds delay
    }

    public void LoadLevel4()
    {
        StartCoroutine(LoadLevelWithDelay("Level4", 3f)); // 3 seconds delay
        flashlightController.LightTime = 0;
    }
    public void LoadLevel5()
    {
        StartCoroutine(LoadLevelWithDelay("Level5", 3f)); // 3 seconds delay
    }

    private IEnumerator LoadLevelWithDelay(string levelName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(levelName); 
    }
    
    public void OnPlayClick()
    {
        LoadLevel1();
    }
}
