using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class lvlcontroler : MonoBehaviour
{
 
    public int index;
    public Animator animator;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("open", true);
            SceneManager.LoadScene(index);
            

        }
        else
        {
           // animator.SetBool("open", false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
