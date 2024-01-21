using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitPoint : MonoBehaviour
{
    public int health = 100;

    [SerializeField]
    private GameObject convert;


    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Instantiate(convert, Vector3.zero, Quaternion.identity);
        FindObjectOfType<GameManager>().EndGame();

    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
