using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float vel = 50;
    private float moveH,moveV;
    public Animator anim;
    public static int colectables;
    private bool walking = false;
    public AudioSource colected;


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
            transform.Translate(playerDirection * vel );
            walking = true;
        }
        else
        {
            walking = false;
        }
        

        anim.SetFloat("Horizontal",moveH);
        anim.SetFloat("vertical",moveV);
        anim.SetBool("isWalking",walking);
    }

    //Player Colections

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Letter"))
        {
            other.gameObject.SetActive(false);
            colected.Play();
            colectables++;
        }
        Debug.Log("Colected!!!");
    }

}