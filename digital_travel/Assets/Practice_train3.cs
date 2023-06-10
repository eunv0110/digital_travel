using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_train3 : MonoBehaviour
{
    public GameObject Window1;
    public GameObject Window2;
    public GameObject Window3;
    public GameObject Window4;
    public GameObject Window5;


    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;

    public GameObject Page3;
    public GameObject Page4;
    public GameObject Page5;








    public void NextButton()
    {
        Window1.SetActive(false);
        Button1.SetActive(true);
    }



    public void ActiveButton2()
    {
        Button1.SetActive(false);
        Button2.SetActive(true);

    }

    public void ToWindow2()
    {
        Window2.SetActive(true);
        print("ff");
    }


    public void ActiveButton3()
    {
        Window2.SetActive(false);
        Button3.SetActive(true);
    }

    public void ToWindow3()
    {
        Window3.SetActive(true);
    }


    public void ToPage4()
    {
        Page3.SetActive(false);
        Page4.SetActive(true);
    }
}
