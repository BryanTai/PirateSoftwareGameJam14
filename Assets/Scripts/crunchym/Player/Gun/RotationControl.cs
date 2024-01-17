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
            transform.localEulerAngles = new Vector3(0, 0, 90);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localEulerAngles = new Vector3(0, 0, -90);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.W) && Input.GetButtonDown("Horizontal"))
        {
            transform.localEulerAngles = new Vector3(0, 0, 45);
        }
        if (Input.GetButton("Horizontal") && Input.GetKeyDown(KeyCode.W))
        {
            transform.localEulerAngles = new Vector3(0, 0, 45);
        }

        if (Input.GetKey(KeyCode.S) && Input.GetButtonDown("Horizontal"))
        {
            transform.localEulerAngles = new Vector3(0, 0, -45);
        }
        if (Input.GetButton("Horizontal") && Input.GetKeyDown(KeyCode.S))
        {
            transform.localEulerAngles = new Vector3(0, 0, -45);
        }

    }


}
