using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faileffect : MonoBehaviour
{
    public AudioSource failSound;
    public AudioSource correctSound;
    public AudioSource clickSound;
    public AudioSource sucessSound;



    public void failClickSound()
    {
        failSound.Play();
    }

    public void correctClickSound()
    {
        correctSound.Play();
    }

    public void ClickSound()
    {
        clickSound.Play();
    }

    public void SucessSound()
    {
        sucessSound.Play();
    }
}
