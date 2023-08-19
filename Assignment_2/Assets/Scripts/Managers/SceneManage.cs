using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public void LoadLevel1()
    {
        StartCoroutine(LoadLevelWithDelay("Level1", 3f)); // 3 seconds delay
    }

    public void LoadLevel2()
    {
        StartCoroutine(LoadLevelWithDelay("Level2", 3f)); // 3 seconds delay
    }

    public void LoadLevel3()
    {
        StartCoroutine(LoadLevelWithDelay("Level3", 3f)); // 3 seconds delay
    }

    private IEnumerator LoadLevelWithDelay(string levelName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(levelName); 
    }
}
