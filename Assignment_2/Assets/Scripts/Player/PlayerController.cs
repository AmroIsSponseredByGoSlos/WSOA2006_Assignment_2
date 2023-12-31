using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject Light;
    public GameObject Player;
    public GameObject CrateLight;
    public GameObject OtherCrateLight;
    public GameObject EnemyPrefab;
    public GameObject FlagPrefab;
    public Text FlagTxt;
    
    private Vector2 lastMoveDirection = Vector2.zero; // Add this variable at the top of your class
    
    [SerializeField] private Transform HoldingPoint;
    [SerializeField] private Transform _player;
    
    public bool HoldingCrate = false;
    
    public int ActiveBlock = 0;
    public int FlagCount = 5 ;
    void Start()
    {
        Player = gameObject;
        FlagTxt = GameObject.Find("FlagTxt").GetComponent<Text>();
    }


    void Update()
    {
        float HorizontalMove = Input.GetAxis("Horizontal");
        float VerticalMove = Input.GetAxis("Vertical");
        Vector2 MoveDirection = new Vector2(HorizontalMove, VerticalMove);

        if (MoveDirection != Vector2.zero)
        {
            lastMoveDirection = MoveDirection; // Store the non-zero input direction
        }

        transform.Translate(lastMoveDirection * 2.8f * Time.deltaTime, Space.World);
        transform.up = lastMoveDirection.normalized;

        if (Input.GetKeyDown(KeyCode.Space) && FlagCount > 0)
        {
            SpawnFlagMark();
            FlagCount--;
        }
        FlagTxt.text = "Flags Remaining : " + FlagCount;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "RedCrate")
        {
            HoldingCrate = true;
            col.transform.parent = Player.transform;
            Light.SetActive(false);
            CrateLight.SetActive(true);
            OtherCrateLight.SetActive(true);
            ActiveBlock = 1;
        }
    }

    void SpawnFlagMark()
    {
        GameObject NewFlag = Instantiate(FlagPrefab,_player.transform.position, Quaternion.identity);            
    }
    
    
}
