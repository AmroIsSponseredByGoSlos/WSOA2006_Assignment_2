using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Light;
    public GameObject Player;
    public GameObject CrateLight;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalMove = Input.GetAxis("Horizontal");
        float VerticalMove = Input.GetAxis("Vertical");
        Vector2 MoveDirection = new Vector2(HorizontalMove, VerticalMove);
        transform.Translate(MoveDirection * 2.8f * Time.deltaTime, Space.World);
        transform.up = MoveDirection.normalized;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Crate")
        {
            col.transform.parent = Player.transform;
            Light.SetActive(false);
            CrateLight.SetActive(true);
        }
    }
}
