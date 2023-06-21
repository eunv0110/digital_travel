using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Final : MonoBehaviour
{
    public void GoNextPage()
    {
        SceneManager.LoadScene("Final");
    }
    public void Exit()
    {
        SceneManager.LoadScene("TravelScene");
    }
}
