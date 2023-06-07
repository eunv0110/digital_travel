using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeToFoodOrderScene : MonoBehaviour
{
    public void NextPlayScene()
    {
        SceneManager.LoadScene("Food_Order");
    }
}
