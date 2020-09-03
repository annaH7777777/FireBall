using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactoryScript : MonoBehaviour
{
    public Transform ballFactoryPoint;
    public GameObject ballPrefab;
    public float ballForce;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Update is called once per frame
    void Start()
    {

        InvokeRepeating("Fall", startDelay, spawnInterval);
       
    }
    void Update()
    {
        
    }
    void Fall()
    {
        GameObject ball = Instantiate(ballPrefab, ballFactoryPoint.position, ballFactoryPoint.rotation);
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        rb.AddForce(ballFactoryPoint.up * ballForce, ForceMode2D.Impulse);
    }
}
