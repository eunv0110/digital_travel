using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Food_Button : MonoBehaviour
{
    public GameObject Text1; // UI 텍스트 오브젝트에 대한 참조
    public GameObject Text2;

    public GameObject Text_button;// 버튼 오브젝트에 대한 참조
    public GameObject Text_button2;
    public void OnButtonClick()
    {
        Text1.SetActive(false);
        Text_button.SetActive(false);
        Text_button2.SetActive(true);
        Text2.SetActive(true);
    }
}
