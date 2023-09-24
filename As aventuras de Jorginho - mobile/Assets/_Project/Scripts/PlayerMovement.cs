using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float vel = 50;
    private float moveH,moveV;
    public static int colectables;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");

        Vector2 playerDirection = new Vector2(moveH,moveV);

        if(playerDirection != Vector2.zero)
        {
            transform.Translate(playerDirection * vel);
        }
    }

    //Player Colections

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Letter"))
        {
            other.gameObject.SetActive(false);
            colectables++;
        }
        Debug.Log("Colected!!!");
    }
}