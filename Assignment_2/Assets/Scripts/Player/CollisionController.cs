using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public PlayerController playerController;
    public SceneManage _SceneManage;
    [SerializeField]private GameObject PanelEnd;
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
            PanelEnd.SetActive(true);
            _SceneManage.LoadLevel2();    
        }
        
        if (col.gameObject.CompareTag("Level2Crate"))
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            PanelEnd.SetActive(true);
            _SceneManage.LoadLevel3();    
        }
        
        if (col.gameObject.CompareTag("Level3Crate"))
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            PanelEnd.SetActive(true);
            _SceneManage.LoadLevel4();
        }
        
    }
}
