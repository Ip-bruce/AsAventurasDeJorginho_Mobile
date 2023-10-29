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
        Vector2 pos = new Vector2(-5,6);
        obstacles[0].transform.position = pos;
    }
}
