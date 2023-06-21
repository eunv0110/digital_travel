using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextKiosk_Script : MonoBehaviour
{
    public GameObject next1;
    public GameObject next2;
    public GameObject next3;
    public GameObject next4;


    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;




    public void Topage2()
    {
        page1.SetActive(false);
        next1.SetActive(false);
        page2.SetActive(true);
        next2.SetActive(true);

    }

    public void Topage3()
    {
        page2.SetActive(false);
        next2.SetActive(false);
        page3.SetActive(true);
        next3.SetActive(true);

    }


    public void Topage4()
    {
        page3.SetActive(false);
        page4.SetActive(true);


    }

    public void ToPlayScene()
    {
        SceneManager.LoadScene("Kiosk_Play");

    }
}
