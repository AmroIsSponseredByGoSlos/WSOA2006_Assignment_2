using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (playerController.ActiveBlock == 1 && col.gameObject.name == "RedCrate2")
        {
            Debug.Log("Line Connected");
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }
}
