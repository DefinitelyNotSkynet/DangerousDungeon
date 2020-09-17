using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroypartical : MonoBehaviour
{
    public float ddistance = 1;
    // public GameObject child;
    public bool pickeddup;
    // public Transform parent;
    RaycastHit2D pickhit;
   

    private void Update()
    {
        pickhit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, ddistance);
        if (pickhit.collider.tag == "puzzleobject")
        {
            GetComponent<Collider2D>().enabled = false;
        }
        else
        {
            GetComponent<Collider2D>().enabled = true;
        }


    }
}
  
               
    // Update is called once per frame
    