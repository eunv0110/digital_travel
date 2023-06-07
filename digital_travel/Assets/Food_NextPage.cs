using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Food_NextPage : MonoBehaviour
{
    public void NextPlayScene()
    {
        SceneManager.LoadScene("Food_Play");
    }
}
