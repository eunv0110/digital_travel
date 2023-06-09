using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class TicketDay : MonoBehaviour
{
    public GameObject ConcertInfo;
    public GameObject Button1;


    public void AppearInfo()
    {
        ConcertInfo.SetActive(true);
        Button1.SetActive(true);
    }
    public void NextScene()
    {
        SceneManager.LoadScene("Ticket_Seat");
    }
}