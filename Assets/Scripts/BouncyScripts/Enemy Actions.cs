using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public float speed;
    public int enemyjumppower;
    //Vector2 enemyjump = new Vector2(0, enemyjumppower);
    Vector2 enemyjump;
    // Start is called before the first frame update
    void Start()
    {
        enemyjump = new Vector2(0, enemyjumppower);
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 enemyleftmove = this.transform.position;
        enemyleftmove.x -= speed;
        this.transform.position = enemyleftmove;



        //Debug.Log("COLLIDING " + collision.gameObject.name);


    }

    
}
