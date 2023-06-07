using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ticket_Select1 : MonoBehaviour
{
    public Text[] textsToDisable;
    public GameObject region_text;
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
            if (text != GetComponent<Text>())
            {
                text.enabled = false;
                region_text.SetActive(true);
            }
        }
    }
}
