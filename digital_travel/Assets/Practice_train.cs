using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Practice_train : MonoBehaviour
{
    public GameObject Window1;
    public GameObject Window2;
    public GameObject Window3;
    public GameObject Window4;

    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;

    public GameObject Page1;
    public GameObject Page2;
    public GameObject Page3;
    public GameObject Page4;







    public void NextButton()
    {
        Window1.SetActive(false);
        Window2.SetActive(true);

    }



    public void NextButton2()
    {
        Window2.SetActive(false);
        Window3.SetActive(true);

    }

    public void NextButton3()
    {
        Window3.SetActive(false);
        Button1.SetActive(true);

    }

    public void ActiveButton2()
    {
        Button1.SetActive(false);
        Button2.SetActive(true);

    }

    public void ToWindow4()
    {
        Window4.SetActive(true);
    }


    public void ToPage2()
    {
        Page1.SetActive(false);
        Page2.SetActive(true);

    }
}
