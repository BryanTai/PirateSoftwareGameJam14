using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        //We are telling "RB" to move times its speed
        rb.velocity = transform.right * speed;
    }

    //this is our when it collieds
    //void OnTriggerEnter2D (Collider2D hitInfo){}
        
}
