using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boost : MonoBehaviour
{
   
    public int boostcoast = 5;
    public manabar Manabar;
    
    public Transform boostpoint;
    public GameObject bosot;
    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetButtonDown("Fire3") )
        {
            if (Manabar.curentmana >= 10)
            {

                //    Debug.Log("cast");
                StartCoroutine(StartWait());

                shoot();

            }


        }


    }

    void shoot()
    {
        Instantiate(bosot, boostpoint.position, boostpoint.rotation);
        
        Manabar.Setmana(Manabar.curentmana-boostcoast);
        StartWait();
    
        //   Debug.Log("cast2");
       
    }
    //start wait subrutine
    IEnumerator StartWait()
    {

        yield return StartCoroutine(Wait());

    }

    //wait subrutine
    IEnumerator Wait()
    {

        yield return new WaitForSeconds(1f);
      


    }
   
    }

