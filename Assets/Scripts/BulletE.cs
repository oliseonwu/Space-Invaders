using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletE : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;
  
    public float speed = 5;
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        Fire();
    }

    // Update is called once per frame
    private void Fire()
    {
        myRigidbody2D.velocity = Vector2.down * speed; 
    }
}
