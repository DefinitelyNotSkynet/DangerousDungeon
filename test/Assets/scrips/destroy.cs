using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartWait());
    }

    // Update is called once per frame
    void Update()
    {
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
}
