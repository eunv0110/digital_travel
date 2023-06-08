using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TicketPlay : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;

    public void TicketPlayScene()
    {
        SceneManager.LoadScene("Ticket_Play");
    }
    public void ButtonColorChange()
    {
        Button1.SetActive(false);
        Button2.SetActive(true);
        Button3.SetActive(true);



    }
    public void TicketPlayScene2()
    {
        SceneManager.LoadScene("TicketDay");
    }
    public void BusText()
    {
        SceneManager.LoadScene("Bus_Play");

    }
}
