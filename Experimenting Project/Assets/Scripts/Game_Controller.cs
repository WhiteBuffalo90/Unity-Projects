using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Game_Controller : MonoBehaviour {


    public double basicMoney = 0f;

    public TextMeshProUGUI basicMoneyText;

    private string abvValue;

    private void Update()
    {

        basicMoney += 5000000000000.123f;
        
        

        if(basicMoney > 1000 && basicMoney < 1000000)
        {
            abvValue = "K";
            
            basicMoneyText.text =  Math.Floor(basicMoney / 1000).ToString("F0") + abvValue;
             
        }
        else if(basicMoney >= 1000000 && basicMoney < 1000000000)
        {
            abvValue = "M";

            basicMoneyText.text = Math.Floor(basicMoney / 1000000).ToString("F0") + abvValue;
        }
        else if (basicMoney >= 1000000000 && basicMoney < 1000000000000)
        {
            abvValue = "B";

            basicMoneyText.text = Math.Floor(basicMoney / 1000000000).ToString("F0") + abvValue;
        }
        else if (basicMoney >= 1000000000000 && basicMoney < 1000000000000000)
        {
            abvValue = "T";

            basicMoneyText.text = Math.Floor(basicMoney / 1000000000000).ToString("0") + abvValue;
        }
        else if (basicMoney >= 1000000000000000 && basicMoney < 1000000000000000000)
        {
            abvValue = "a";

            basicMoneyText.text = Math.Floor(basicMoney / 1000000000000000).ToString("0") + abvValue;
        }
        else if (basicMoney >= 1000000000000000000 && basicMoney < 1000000000000000000000f)
        {
            abvValue = "b";

            basicMoneyText.text = Math.Floor(basicMoney / 1000000000000000000f).ToString("F0") + abvValue;
        }
        else if (basicMoney >= 1000000000000000000000f && basicMoney < 1000000000000000000000000f)
        {
            abvValue = "c";

            basicMoneyText.text = Math.Floor(basicMoney / 1000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (basicMoney >= 1000000000000000000000000f && basicMoney < 1000000000000000000000000000f)
        {
            abvValue = "d";

            basicMoneyText.text = Math.Floor(basicMoney / 1000000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (basicMoney >= 1000000000000000000000000000f && basicMoney < 1000000000000000000000000000000f)
        {
            abvValue = "e";

            basicMoneyText.text = Math.Floor(basicMoney / 1000000000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (basicMoney >= 1000000000000000000000000000000f && basicMoney < 1000000000000000000000000000000000f)
        {
            abvValue = "f";

            basicMoneyText.text = Math.Floor(basicMoney / 1000000000000000000000000000000f).ToString("F0") + abvValue;
        }
        else
        {
            basicMoneyText.text = basicMoney.ToString("F0");
        }

    }

}

