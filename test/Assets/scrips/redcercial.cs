using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Readcercialsocet : MonoBehaviour
{
    public float ddistance = 1;
    // public GameObject child;
    public bool pickeddup;
    // public Transform parent;
    RaycastHit2D pickhit;
    public Animator animator;
    public Transform unlockpoint;
    bool ON;

    public void Unlock(Transform newParent)
    {


    }


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {


        if (!pickeddup)
        {

            pickhit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, ddistance);


            if (pickhit.collider != null)
            {

                if (pickhit.collider.tag == "puzzleobjectbluesquare")
                {

                    animator.SetBool("on", true);
                    pickeddup = true;
                }



            }


        }
        else
        {

        }



        if (pickeddup == true)
        {
            //   Debug.Log("pass");
            pickhit.collider.gameObject.transform.position = unlockpoint.position;

            //    pickedup = false;
        }
        else
        {
            animator.SetBool("on", false);
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            pickeddup = false;

        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * transform.localScale.x * ddistance);
    }
}
