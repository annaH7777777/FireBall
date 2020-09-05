using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    bool collision = false;
    public GameObject ball;


    private void Update()
    {
        if (collision == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Button");
                Destroy(ball);
                Destroy(gameObject);
            }
            else
            {
                // GameOver();
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        collision = true;
        ball = other.gameObject;
        Debug.Log("Collision");
    }
}
