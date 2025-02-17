using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;   
    //public  SpriteRenderer spriteRenderer;
    public Image spriteRenderer;
    public Sprite [] scoreImages ;


    private void Awake()
    {
        instance = this;
        spriteRenderer.GetComponent<Image>();
    }
   


    public void SetSprite(int index)
    {
        spriteRenderer.sprite = scoreImages[index];
    }

}
