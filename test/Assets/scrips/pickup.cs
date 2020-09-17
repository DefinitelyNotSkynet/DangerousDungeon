using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public float distance = 1;
   // public GameObject child;
    public bool pickedup;
   // public Transform parent;
    RaycastHit2D hit;
   
    public Transform carrypoint;


    public void Pickupp(Transform newParent)
    {


    }


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {

            if (!pickedup)
            {
                hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance);

             
                if (hit.collider != null )
                {
                    if (hit.collider.tag == "puzzleobject")
                    {

                        pickedup = true;
                    }
                     
                          if (hit.collider.tag == "puzzleobjectbluesquare")
                    {

                        pickedup = true;
                    }

                    if (hit.collider.tag == "puzzleobjectredsquare")
                    {

                        pickedup = true;
                    }
                    
                         if (hit.collider.tag == "puzzleobjecredcercial")
                    {

                        pickedup = true;
                    }

                    if (hit.collider.tag == "puzzleobjecbluecercial") 
                    {

                        pickedup = true;
                    }
                   
                }
            }
            else
            {

            }

        }

        if (pickedup == true)
        {
          //   Debug.Log("pass");
            hit.collider.gameObject.transform.position = carrypoint.position;
        //    pickedup = false;
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            pickedup = false;
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * transform.localScale.x * distance);
    }
}


    
