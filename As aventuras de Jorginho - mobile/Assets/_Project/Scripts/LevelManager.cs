using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject path;
    public bool isPathOpen;
    public int letterAmount;
    public GameObject colectable1,colectable2;
    // Start is called before the first frame update
    void Start()
    {
        isPathOpen = false;
        path.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckPath()
    {

    }

    public void OnCollisionEnter2D(Collision2D other) 
    {
        if(isPathOpen)
        {
            path.SetActive(false);
        }

        if(other.gameObject.tag == "Letter")
        {
            other.gameObject.SetActive(false);
        }
        Debug.Log("Collision");
        // if(letterAmount == colectables.length)
        // {
        //     if(!colectables.length.SetActive)
        //     {
        //         isPathOpen = true;
        //     }
        // }    
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
          if(isPathOpen)
        {
            path.SetActive(false);
        }

        if(other.gameObject.tag == "Letter")
        {
            other.gameObject.SetActive(false);
        }   
        
        
            if(!colectable1 && !colectable2)
            {
                isPathOpen = true;
            }
         
        Debug.Log("triggerEnter");

    }

}
