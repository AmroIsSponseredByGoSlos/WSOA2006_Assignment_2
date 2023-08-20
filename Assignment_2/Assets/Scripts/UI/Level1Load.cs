using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Load : MonoBehaviour
{
    public void OnPlayClick()
    {
        SceneManager.LoadScene("Level1");
    }
}
