using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSystem : MonoBehaviour
{
    public GameObject[] obstacles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            StartPosition();
        }
    }

    public void StartPosition()
    {
        for (int i = 0; i < obstacles.Length; i++)
        {
            Vector2 pos = new Vector2(Random.Range(-5,5),Random.Range(6,8));
            obstacles[i].transform.position = pos;
            
        }
    }
}
