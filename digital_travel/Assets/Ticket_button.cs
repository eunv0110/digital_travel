using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ticket_button : MonoBehaviour
{
    public Text Text1; // UI 텍스트 오브젝트에 대한 참조
    public GameObject Text2_button; // 버튼 오브젝트에 대한 참조
    public GameObject TicketPlay_button;

    public void OnButtonClick()
    {
        Text1.text = "새로운 텍스트"; // 텍스트 변경
        Text2_button.SetActive(false); // 버튼 비활성화하여 숨김
        TicketPlay_button.SetActive(true);
    }
}
