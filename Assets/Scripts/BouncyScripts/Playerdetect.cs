using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerdetect : MonoBehaviour
{
    public int enemyjumppower;
    //Vector2 enemyjump = new Vector2(0, enemyjumppower);
    Vector2 enemyjump;
    public GameObject catgirl;
    private bool istouchingfloor;
    // Start is called before the first frame update
    void Start()
    {
        enemyjump = new Vector2(0, enemyjumppower);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D enemycollision)
    {
        if (enemycollision.tag == "Floor")
        {
            Debug.Log("FLOOR!");
            istouchingfloor = true;

            
        }

        if (enemycollision.gameObject.name == "Player" && istouchingfloor == true)
        {
            Debug.Log("OWO");
            catgirl.GetComponent<Rigidbody2D>().AddForce(enemyjump);
        }
    
    }
    void OnTriggerExit2D(Collider2D enemycollision)
    {
        if (enemycollision.tag == "Floor")
        {
            Debug.Log("WHEEEE!");
            istouchingfloor = false;

        }



    }
}
