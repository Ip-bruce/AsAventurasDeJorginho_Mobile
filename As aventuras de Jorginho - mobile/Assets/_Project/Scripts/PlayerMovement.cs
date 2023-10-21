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
    //public SpriteRenderer playerSprite;
    //public Sprite[] spriteList ;
    // Start is called before the first frame update
    void Start()
    {
        //playerSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();
       // PlayerAnimator();
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
            colectables++;
        }
        Debug.Log("Colected!!!");
    }

    // public void PlayerAnimator()
    // {
    //     if(moveH >= 1)
    //     {
    //         playerSprite.sprite = spriteList[1];
    //     }
    //     if(moveH == 0)
    //     {
    //         playerSprite.sprite = spriteList[0];
    //     }
    //     if(moveH < 0)
    //     {
    //         playerSprite.sprite = spriteList[2];
    //     }
    // }
}