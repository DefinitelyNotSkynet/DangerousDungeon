using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public pickup Pickup;
    public float runspeed = 40f;
    float horzmove = 0f;
    public static bool jump = false;
    bool crouch = false;
    // Update is called once per frame
    void Update()
    {
        

        horzmove = Input.GetAxisRaw("Horizontal") * runspeed;

        animator.SetFloat("speed", Mathf.Abs(horzmove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;

          //  Debug.Log("cast");
            animator.SetBool("is jumping", true);

        }


        if (Input.GetButtonDown("Crouch")) {
            GetComponent<CircleCollider2D>().enabled = false;
           
            animator.SetBool("is ducking", true);
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            GetComponent<CircleCollider2D>().enabled = true;
            animator.SetBool("is ducking", false);
        }



    }









   

    public void Onlanding()
    {
        animator.SetBool("is jumping", false);
    }
    //update called fixed number of times
    private void FixedUpdate()
    {
        {
            //move char
            controller.Move(horzmove * Time.fixedDeltaTime, false, jump);
            jump = false;
        }
    }
}
