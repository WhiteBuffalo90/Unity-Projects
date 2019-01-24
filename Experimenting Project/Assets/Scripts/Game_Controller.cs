using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game_Controller : MonoBehaviour {


    private double basicMoney = 0f;

    TextMeshProUGUI basicMoneyText;

    private void Update()
    {

        basicMoney += 5.123f;

        Debug.Log(basicMoney.ToString(""));

    }

}

