using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public static bool collision = false;
    public GameObject ball;
    


    
    private void OnCollisionEnter2D(Collision2D other)
    {
        collision = true;
        ball = other.gameObject;
        Debug.Log("Collision");
    }
}
