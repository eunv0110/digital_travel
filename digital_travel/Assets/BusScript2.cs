using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusScript2 : MonoBehaviour
{
    public GameObject Help1;
    public GameObject Help1_2;

    public GameObject Help2;
    public GameObject Help2_2;

    public void BusHelp1()
    {
        Help1.SetActive(true);
    }

    public void CloseBusHelp1()
    {
        Help1.SetActive(false);
    }


    public void BusHelp1_2()
    {
        Help1.SetActive(false);
        Help1_2.SetActive(true);

    }

    public void CloseBusHelp1_2()
    {
        Help1_2.SetActive(false);

    }


    public void BusHelp2()
    {
        Help2.SetActive(true);
    }

    public void CloseBusHelp2()
    {
        Help2.SetActive(false);
    }


    public void BusHelp2_2()
    {
        Help2.SetActive(false);
        Help2_2.SetActive(true);

    }

    public void CloseBusHelp2_2()
    {
        Help2_2.SetActive(false);

    }


}
