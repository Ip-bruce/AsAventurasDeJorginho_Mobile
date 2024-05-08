using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneManager : MonoBehaviour
{
  

    [Header("Cutscene Manager")]

    [Header("Images")]
    //create a image array
    [SerializeField] 
    private Sprite [] images;
    [SerializeField] [Range(0,100)]
    private float TimeInScene;

    //Image Object reference to show the images
    [SerializeField]
    private Image imageShow;


    //Private variables - Timer
    private bool isInScene = true;
    private float timer;
    private int index = 0 ;

    // Start is called before the first frame update
    void Start()
    {
        isInScene = true;
    }


    void FixedUpdate()
    {
        if(isInScene)
        {
            timer += Time.deltaTime;
            Debug.Log("time is:" + timer );
        } 

        if(timer >= TimeInScene)
        {
            timer = 0;
            imageShow.sprite = images[index];
            
            if(index == images.Length - 1 )
            {
                Debug.Log("Acabbou as images");
                isInScene = false;
                
            }
            else
            {
                index++;
            }
        }
        
    }

}
