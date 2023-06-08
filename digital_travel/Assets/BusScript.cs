using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusScript : MonoBehaviour
{
    public GameObject SeoulButton;
    public GameObject SeoulButton2;
    public GameObject SeoulButton3;
    public GameObject TrainButton;

    public GameObject Page1;
    public GameObject Page2;
    public GameObject Page3;
    public GameObject Page3_1;

    public GameObject Page4;
    public GameObject Page5;
    public GameObject Page5_1;
    public GameObject Page5_2;
    public GameObject Page5_3;




    public GameObject FinalPage;



    public GameObject Page2_Button;
    public GameObject Page3_Button;
    public GameObject Page3_Button2;
    public GameObject Page3_Button3;
    public GameObject Page5_CardButton;




    public GameObject ToPage3_Button;
    public GameObject ToFinalPage_Button;







    public void SelectSeoul()
    {
        SeoulButton.SetActive(true);
        SeoulButton2.SetActive(true);
        SeoulButton3.SetActive(true);


    }
    public void ToPage2()
    {
        Page1.SetActive(false);

        Page2.SetActive(true);
        Page2_Button.SetActive(true);
    }

    public void SelectedTrain()
    {

        TrainButton.SetActive(true);
        ToPage3_Button.SetActive(true);
    }

    public void ToPage3()
    {
        Page2.SetActive(false);

        Page3.SetActive(true);
        ToPage3_Button.SetActive(true);
    }

    public void selectseat()
    {
        Page3_Button.SetActive(true);
        Page3_Button2.SetActive(true);
        Page3_Button3.SetActive(true);


    }

    public void ToPage4()
    {
        Page3_1.SetActive(false);

        Page4.SetActive(true);
    }

    public void ToPage5()
    {
        Page4.SetActive(false);

        Page5_1.SetActive(true);
        Page5_2.SetActive(true);
        Page5_3.SetActive(true);

    }

    public void BusCard()
    {
        Page5_CardButton.SetActive(true);
        ToFinalPage_Button.SetActive(true);


    }

    public void ToFinalPage()
    {
        Page5.SetActive(false);

        FinalPage.SetActive(true);
    }


}
