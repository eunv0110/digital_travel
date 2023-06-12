using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ImageChange : MonoBehaviour
{
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;


    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;





    public void Change()
    {
        Image1.SetActive(false);
        Button1.SetActive(false);

        Image2.SetActive(true);
        Button2.SetActive(true);

    }


    public void Change2()
    {
        Image2.SetActive(false);
        Button2.SetActive(false);

        Image3.SetActive(true);
        Button3.SetActive(true);

    }

    public void Change3()
    {
        Image3.SetActive(false);
        Button3.SetActive(false);

        SceneManager.LoadScene("Ticket_Text");
    }

    public void Train_Change()
    {
        Image1.SetActive(false);
        Button1.SetActive(false);

        Image2.SetActive(true);
        Button2.SetActive(true);

    }

    public void Train_Change2()
    {
        Image2.SetActive(false);
        Button2.SetActive(false);

        SceneManager.LoadScene("Bus_Text");


    }



}
