using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public static bool collision = false;
    public GameObject ball;
    public GameManager gm;
    public Playerscript player;


    private void Update()
    {
        /*if (collision == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Button");
                Destroy(ball);
                Destroy(gameObject);
            }
            else
            {
                gm.GameOver();
            }
        }*/
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        collision = true;
        ball = other.gameObject;
        Debug.Log("Collision");
    }
}
