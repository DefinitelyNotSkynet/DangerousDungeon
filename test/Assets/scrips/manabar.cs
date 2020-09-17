using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class  manabar : MonoBehaviour
{
    //public static int mana;
  
    public int maxmana = 100;
    public int curentmana = 100;
    public Slider slider;
    public float refreasrate = 1f;

    public void Setmana(int mana )
    {
       curentmana = mana;
        slider.value = curentmana;
        StartCoroutine(StartWait());
        StartWait();
    }
    public void SetMaxmana(int mana)
    {
        maxmana = mana;
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

        yield return new WaitForSeconds(refreasrate);

        if (curentmana < maxmana)
        {
            Setmana(curentmana + 1);
        }
    }
}
