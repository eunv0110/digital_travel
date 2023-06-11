using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public void KioskTrainingScene()
    {
        SceneManager.LoadScene("Kiosk_PracticeScene");
    }

    public void KioskStoryScene()
    {
        SceneManager.LoadScene("Kiosk_Story");
    }
}
