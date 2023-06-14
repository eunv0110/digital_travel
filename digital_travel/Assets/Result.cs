using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;

    public GameObject b1;
    public GameObject b2;
    public GameObject b2_2;
    public GameObject b2_3;

    public void Activepage1()
    {
        page1.SetActive(true);
        b1.SetActive(true);
        b2.SetActive(false);
        b2_2.SetActive(false);
        b2_3.SetActive(false);



        page2.SetActive(false);


    }

    public void Activepage2()
    {
        page2.SetActive(true);
        page1.SetActive(false);
        b2.SetActive(true);
        b2_2.SetActive(true);
        b2_3.SetActive(true);


    }

    public void GoPractice()
    {
        SceneManager.LoadScene("PracticeScene");
    }


}
