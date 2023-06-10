using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prat_Ticket_ChangeScene : MonoBehaviour
{
    public void GoPracticeScene()
    {
        SceneManager.LoadScene("PracticeScene");
    }
}
