using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTravel : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("TravelScene");
    }

}
