using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_combat : MonoBehaviour
{

    public Animator playerattack;
    public float attackrange = 0.5f;
    public LayerMask enemylayer;
    public Transform meleattaclpoint;
    public int atkdmg = 40;
    public float atkrate = 2f;
    float nextatk = 1f;
   
    // Update is called once per frame
    void Update()
    {
       
        

            Attack();
           
        
    }

   

    void Attack()
    {
        


        //attack annamation
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            //limit atake rate
            // nextatk = Time.time + 1f / atkrate;


            //set attack anamation bool
            playerattack.SetBool("attacking", true);

            //attack detection
            Collider2D[] hitenemy = Physics2D.OverlapCircleAll(meleattaclpoint.position, attackrange, enemylayer);

            //damage
            foreach (Collider2D enemy in hitenemy)
            {
                enemy.GetComponent<dragonnight>().TakeDamage(atkdmg);
            }
           
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            playerattack.SetBool("attacking", false);
        }


       

    }

    private void OnDrawGizmosSelected()
    {
        if (meleattaclpoint == null)
            return;

        Gizmos.DrawWireSphere(meleattaclpoint.position, attackrange);
    }


}
