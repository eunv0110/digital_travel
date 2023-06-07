using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ticket_Time : MonoBehaviour
{
    public Text[] textsToDisable;
    public GameObject payment;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Text text in textsToDisable)
        {
            text.enabled = true;
        }

    }
    public void OnTextClick()
    {
        // 클릭된 텍스트를 제외한 나머지 텍스트를 비활성화
        foreach (Text text in textsToDisable)
        {
            if (text.gameObject != gameObject)
            {
                text.enabled = false;
                payment.SetActive(true);
            }
        }
    }
}
