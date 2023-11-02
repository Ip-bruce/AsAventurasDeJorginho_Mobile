using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float obstacleVel;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(Random.Range(-6,6),Random.Range(6,10));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0,-1 * obstacleVel ,0);
    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("LevelCollider"))
        {
            Vector2 pos = new Vector2(Random.Range(-6,6),Random.Range(6,10));
            transform.position = pos;
        }
        if(other.gameObject.CompareTag("Player"))
        {
            Vector2 pos = new Vector2(Random.Range(-6,6),Random.Range(6,10));
            transform.position = pos;
            Debug.Log("Hit no personagem");
        }
        else
        {
            return;
        }
    }
}
