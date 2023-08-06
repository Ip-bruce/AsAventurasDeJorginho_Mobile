using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public FixedJoystick joystick;
    public float vel = 50;
    private float moveH,moveV;
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
        moveH = joystick.Horizontal;
        moveV = joystick.Vertical;

        Vector2 playerDirection = new Vector2(moveH,moveV);

        if(playerDirection != Vector2.zero)
        {
            transform.Translate(playerDirection * vel);
        }
    }
}
