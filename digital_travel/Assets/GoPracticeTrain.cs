using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoPracticeTrain : MonoBehaviour
{
    public void GoTrain()
    {
        SceneManager.LoadScene("Practice_Train");
    }


    public void GoTicket()
    {
        SceneManager.LoadScene("Practice_Ticket");
    }

}
