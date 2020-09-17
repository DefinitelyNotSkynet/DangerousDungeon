using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public int maxhp = 100;
    public int curecurhp = 100;
    public Slider slider;


    public void Sethp(int hp)
    {
        curecurhp = hp;
        slider.value = curecurhp;
        StartCoroutine(StartWait());
        StartWait();
    }
    public void SetMaxhp(int hp)
    {
        maxhp = hp;
        // slider.maxValue = maxmana;

    }

    //start wait subrutine
    IEnumerator StartWait()
    {

        yield return StartCoroutine(Wait());

    }

    //wait subrutine
    IEnumerator Wait()
    {

        yield return new WaitForSeconds(2.5f);

        if (curecurhp < maxhp)
        {
            Sethp(curecurhp + 1);
        }
    }
}
 