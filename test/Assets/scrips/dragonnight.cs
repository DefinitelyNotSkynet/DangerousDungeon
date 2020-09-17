using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonnight : MonoBehaviour
{
    CharacterController controller;
    public Animator animator;
    public int maxhp = 100;
    int currenthp;
    public float runspeed = 0f;
    // Start is called before the first frame update
    void Start()
    {

       
       currenthp = maxhp;
    }
    
    public void TakeDamage(int damage)
    {
        currenthp -= damage;

        animator.SetTrigger("hurt");

        if(currenthp <=0)
        {
            StartCoroutine(StartWait());
            Die();
        }

    }

    void Die() 
    {

        animator.SetBool("dead", true);
   
   
        StartWait();
       
       
    }

    //start wait subrutine
    IEnumerator StartWait()
    {
        
        yield return StartCoroutine(Wait());
 
    }

    //wait subrutine
    IEnumerator Wait()
    {
    
        yield return new WaitForSeconds(.5f);
   
        Destroy(gameObject);

    }



   // Update is called once per frame
    void Update()
    {
        
        {

        }




    }

}
