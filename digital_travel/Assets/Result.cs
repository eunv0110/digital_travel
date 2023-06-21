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
        page2.SetActive(false);




    }

    public void Activepage2()
    {
        page2.SetActive(true);
        page1.SetActive(false);


    }

    public void GoPractice()
    {
        SceneManager.LoadScene("PracticeScene");
    }


}
