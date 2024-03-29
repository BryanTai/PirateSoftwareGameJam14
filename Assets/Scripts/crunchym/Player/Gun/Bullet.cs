using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void Update()
    {
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        BossHealth boss = hitInfo.GetComponent<BossHealth>();
        if (boss != null)
        {
            boss.TakeDamage(damage);
        }

        EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

   // void OnTriggerEnter2D(Collider2D hitInfo)
   // {
        //Instantiate(impactEffect, transform.position, transform.rotation);
        //Destroy(gameObject);
   // }
}
