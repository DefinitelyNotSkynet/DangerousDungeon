using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cast : MonoBehaviour
{

    public Transform fierpoint;
    public GameObject fierball;
    // Update is called once per frame
    void Update()
    {
        // Debug.Log("castbrfor");
        if (Input.GetButtonDown("Fire2"))
        {
        //    Debug.Log("cast");
            shoot();
         
        }


    }
    void shoot()
    {
      
        Instantiate(fierball, fierpoint.position , fierpoint.rotation);
     //   Debug.Log("cast2");
    }
}
