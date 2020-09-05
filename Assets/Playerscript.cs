using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce;
    public GameManager gm;
    public bool collision;
    public GameObject ball;
    public GameObject bullet;
    public BallFactoryScript bF;
    public BulletScript bS;

    
    // Update is called once per frame
    void Update()
    {
        if (!GameManager.gameOver)
        {
            if (Input.GetMouseButtonDown(0) && GameObject.FindGameObjectWithTag("bullet") == null)
            {
                
                   Shoot();
                   Debug.Log("Shooting");
            }

            if (BulletScript.collision == true)
            {
                if (Input.GetMouseButton(0))
                {

                    DestroyObjects();
                    Debug.Log("Player destroyed");
                    BulletScript.collision = false;
                    gm.UpdateScore(1);
                }

                else
                {
                    gm.GameOver();
                    DestroyObjects();
                    Debug.Log("Game Over");
                }
            }
        }
    }
    void Shoot()
    {
        bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        bS = bullet.GetComponent<BulletScript>();
    }
    void DestroyObjects()
    {
        Destroy(bullet); Debug.Log("Bullet Destroyed");
        Destroy(bS.ball); Debug.Log("Ball Destroyed");
    }
    }
    
