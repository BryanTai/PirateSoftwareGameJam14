using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //use to refrance the CharCtrl2D script
    public CharacterController2D controller;
    //controls our speed of Char
    public float runSpeed = 60f;
    //"FLOAT" just lest use use decimal numbers
    //We are going to get our player input data from "VoidUpdate" and then use the "Void FixedUpdate" to apply the input to our CHAR 
    float horizontalMove = 0f;

    //bool can only be true of false switch
    private bool jump = false;
    private bool crouch = false;



    // "Void Update" is called once per frame

    //the text "Jump, Crouch, and Horizontal" are coming from the "Input Manager" in the Project Settings
    //witch have input key set up for use
    void Update()
    {
     //this helps tell our char witch direction we are runing
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

     // this is the input data to read jump
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
     // Crouch must be set as else if because we want to be able to hold it down and not just use for an instant use
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }
    // FixedUpdate is dedicated for physics insted of being called once ever frame its called a fixed amount of time persecond 
    void FixedUpdate ()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime , crouch, jump);
        jump = false;


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Win")
        {
            WINTEXT.gameObject.SetActive(true);
        }
    }
}
