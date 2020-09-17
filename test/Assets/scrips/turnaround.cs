using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class turnaround : MonoBehaviour
{
    public Animator animator;
    public AIPath aiPath;
    // Update is called once per frame
    void Update()
    {
        if (aiPath.desiredVelocity.x <= -0.01f)
        {

            animator.SetFloat("speed", (1));
            transform.localScale = new Vector3(-3f, 3f, 1f);

        }
        else if (aiPath.desiredVelocity.x >= 0.01f)
        {


            animator.SetFloat("speed", (1));
            transform.localScale = new Vector3(3f, 3f, 1f);

        }
        else if (aiPath.desiredVelocity.x == 0.0f)
        {
            animator.SetFloat("speed", (0));
        }



    }
}
