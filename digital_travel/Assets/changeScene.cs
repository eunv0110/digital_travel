using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public GameObject button1;

    public void KioskTrainingScene()
    {
        SceneManager.LoadScene("Kiosk_PracticeScene");
    }

    public void KioskStoryScene()
    {
        SceneManager.LoadScene("Kiosk_Story");
    }

    public void TicketStoryScene()
    {
        SceneManager.LoadScene("TravelScene");
    }

    public void TicketToTrain()
    {
        SceneManager.LoadScene("Train_Text0");
    }

    public void ToTravelScene()
    {
        SceneManager.LoadScene("TravelScene");
    }

    public void ToFinal()
    {
        SceneManager.LoadScene("Final");
    }

    public void ToPractice()
    {
        SceneManager.LoadScene("PracticeScene");
    }

    public void ActiveTrue()
    {
        button1.SetActive(true);
    }

    public void ActiveFalse()
    {
        button1.SetActive(false);
    }




}
