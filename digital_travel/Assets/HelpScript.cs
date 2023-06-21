using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpScript : MonoBehaviour
{
    public GameObject Help1;
    public GameObject Help2;
    public GameObject Food1;
    public GameObject Food2;
    public GameObject count;
    public GameObject count2;
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject continuebutton;
    public GameObject count1button;



    public void help1()
    {
        Help1.SetActive(true);

    }


    public void falsehelp1()
    {
        Help1.SetActive(false);

    }

    public void help2()
    {
        Help2.SetActive(true);
        Help1.SetActive(false);

    }

    public void falsehelp2()

    {
        Help2.SetActive(false);
    }

    public void food1()

    {
        Food1.SetActive(true);
        count.SetActive(true);

    }

    public void food2()
    {
        Food2.SetActive(true);
        continuebutton.SetActive(true);
        count1button.SetActive(false);
    }


    public void Page1()
    {
        page1.SetActive(true);
        page2.SetActive(false);
        page3.SetActive(false);
    }


    public void Page2()
    {
        page2.SetActive(true);
        page1.SetActive(false);
        page3.SetActive(false);
    }

    public void Page3()
    {
        page3.SetActive(true);
        page1.SetActive(false);
        page2.SetActive(false);
    }

    public void ToSuccessPage()
    {
        SceneManager.LoadScene("Success_Kiosk");
    }



}
