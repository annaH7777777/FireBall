using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Debug.Log("Collision");
        }
        
        //else GameOver();
    }
}
