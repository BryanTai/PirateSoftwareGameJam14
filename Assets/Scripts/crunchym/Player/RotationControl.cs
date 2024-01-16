using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationControl : MonoBehaviour  
{
   
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Rotate(Vector3.forward, 90);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
            //transform.Rotate(Vector3.forward, 90);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(Vector3.forward, -90);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
            //    transform.Rotate(Vector3.forward, -90);
        }

        if (Input.GetKeyDown(KeyCode.W) && Input.GetButton("Horizontal"))
        {
            transform.localEulerAngles = new Vector3(0, 0, 45);
        }

    }


}
