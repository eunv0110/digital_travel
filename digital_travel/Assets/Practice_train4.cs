using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Practice_train4 : MonoBehaviour
{
    public GameObject Window1;
    public GameObject Window2;
    public GameObject Window3;
    public GameObject Window4;
    public GameObject Window5;


    public GameObject Button1;
    public GameObject Button1_2;

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
        Button1.SetActive(true);
        Button1_2.SetActive(false);
        Button2.SetActive(true);

    }


    public void ToPage5()
    {
        Page4.SetActive(false);
        Page5.SetActive(true);
    }

    public void GoPracticeScene()
    {
        SceneManager.LoadScene("PracticeScene");
    }
}
