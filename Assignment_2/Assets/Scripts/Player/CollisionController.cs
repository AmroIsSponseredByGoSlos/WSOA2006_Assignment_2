using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public PlayerController playerController;
    public FlashlightController _FlashlightController;
    public SceneManage _SceneManage;
    [SerializeField]private GameObject PanelEnd;
    [SerializeField]private GameObject EndScreen;
    [SerializeField] private Timer _timer;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Level1Crate"))
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            _timer.enabled = false;
            PanelEnd.SetActive(true);
            _SceneManage.LoadLevel2();
            _SceneManage.FlagReset = false;
        }
        
        if (col.gameObject.CompareTag("Level2Crate"))
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            _timer.enabled = false;
            PanelEnd.SetActive(true);
            _SceneManage.LoadLevel3();
            _SceneManage.FlagReset = false;
        }
        
        if (col.gameObject.CompareTag("Level3Crate"))
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            _timer.enabled = false;
            PanelEnd.SetActive(true);
            _SceneManage.LoadLevel4();
            _SceneManage.FlagReset = false;
        }
        
        if (col.gameObject.CompareTag("Level4Crate"))
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            _timer.enabled = false;
            PanelEnd.SetActive(true);
            _SceneManage.LoadLevel5();
            _SceneManage.FlagReset = false;
        }
        
        if (col.gameObject.CompareTag("Finish"))
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            _timer.enabled = false;
            playerController.enabled = false;
            _FlashlightController.enabled = false;
            EndScreen.SetActive(true);
        }
        
    }
}
