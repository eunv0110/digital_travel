using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketSeat : MonoBehaviour
{
    public GameObject Area1;
    public GameObject Button1;
    public GameObject Info;
    public GameObject Pay;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public GameObject Button5;


    public GameObject Page1;
    public GameObject Page2;
    public GameObject Page3;
    public GameObject Page4;








    public void ClickSeat1()
    {
        Area1.SetActive(true);
        Button1.SetActive(true);

    }

    public void InfoPage()
    {
        Info.SetActive(true);
        Page1.SetActive(false);
        Button2.SetActive(true);
        Button1.SetActive(false);



    }


    public void PayHow()
    {
        Pay.SetActive(true);
        Page2.SetActive(false);
        Button2.SetActive(false);


    }

    public void ActivePayHow()
    {
        Button3.SetActive(true);
        Button4.SetActive(true);


    }
    public void TicketFinish()
    {
        Pay.SetActive(false);
        Button3.SetActive(false);
        Button4.SetActive(false);
        Button5.SetActive(false);

        Page3.SetActive(false);
        Page4.SetActive(true);





    }
}
