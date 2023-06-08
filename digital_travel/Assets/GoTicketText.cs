using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoTicketText : MonoBehaviour
{
    public void TicketText()
    {
        SceneManager.LoadScene("Ticket_Text");
    }
    public void TicketDay()
    {
        SceneManager.LoadScene("TicketText");
    }

    public void BusText()
    {
        SceneManager.LoadScene("Bus_Text");
    }

}
