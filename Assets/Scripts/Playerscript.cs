using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
   
    public GameObject bulletPrefab;
    public float bulletForce;
    public GameManager gm;
    public bool collision;
    public GameObject bullet;
    public BulletScript bulletScript;

    
    // Update is called once per frame
    void Update()
    {
        if (!GameManager.gameOver)
        {
            if (Input.GetMouseButtonDown(0) && (GameObject.FindGameObjectWithTag("bullet") == null))
            {
                Shoot();
                Debug.Log("Shooting");
            }

            if (BulletScript.collision == true)
            {
                if (Input.GetMouseButtonDown(0))
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
                    BulletScript.collision = false;
                }
            }
        }
    }
    void Shoot()
    {
        bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * bulletForce, ForceMode2D.Impulse);
        bulletScript = bullet.GetComponent<BulletScript>();
    }
    void DestroyObjects()
    {
        Destroy(bullet); Debug.Log("Bullet Destroyed");
        Destroy(bulletScript.ball); Debug.Log("Ball Destroyed");
    }
    }
    
