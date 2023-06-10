using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoPractice : MonoBehaviour
{
    public void Practice()
    {
        SceneManager.LoadScene("PracticeScene");
    }

    public GameObject targetObject;
    public float delay = 2f;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(delay);
        targetObject.SetActive(false);
    }
}
