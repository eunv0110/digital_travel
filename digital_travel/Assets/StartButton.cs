using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void PlayScene()
    {
        SceneManager.LoadScene("TravelScene");
    }

    public void ResultScene()
    {
        SceneManager.LoadScene("ResultScene");
    }
}
