using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //TestMode
    public bool isTestModeActive = false;
    //TestMode
    public float vel = 50;
    private float moveH,moveV;
    public Animator anim;
    public static int colectables;
    private bool walking = false;
    public AudioSource colected;
    public string LoseLevel;

    //Player Health stats
    public int PlayerLife = 2;
    public GameObject[] LifeSprite;

    
    void Start()
    {
        //Player Health
        PlayerLife = 2;
        //Life Sprite
        int i;
        for(i = 0; i < LifeSprite.Length; i++)
        {
            LifeSprite[i].SetActive(true);
        }    
    }


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
        if(other.gameObject.CompareTag("Obstacle"))
        {
            if(!isTestModeActive) PlayerHealth();
        }
    }

    private void PlayerHealth()
    {

        if(PlayerLife == 2) LifeSprite[2].SetActive(false);
        if(PlayerLife == 1) LifeSprite[1].SetActive(false);
        if(PlayerLife == 0)
        {
            LifeSprite[0].SetActive(false);
            SceneManager.LoadScene(LoseLevel); 
        }
        
        PlayerLife--;

       
    }

}