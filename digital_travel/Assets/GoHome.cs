using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoHome : MonoBehaviour
{
    public void Home()
    {
        SceneManager.LoadScene("StartScene");
    }


    public void GoTravelScene()
    {
        SceneManager.LoadScene("TravelScene");
    }


    public void GoKiosk()
    {
        SceneManager.LoadScene("Kiosk_Story");
    }
}
