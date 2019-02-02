using System;
using TMPro;
using UnityEngine;

public class Game_Controller : MonoBehaviour
{


    public double woodCur = 0f;
    public double stoneCur = 0f;
    public double metalCur = 0f;
    public double fuelCur = 0f;
    public double powerCur = 0f;

    public TextMeshProUGUI woodText;
    public TextMeshProUGUI stoneText;
    public TextMeshProUGUI metalText;
    public TextMeshProUGUI fuelText;
    public TextMeshProUGUI powerText;

    public float woodTime = 3.0f;
    public float stoneTime = 3.5f;
    public float metalTime = 4.5f;
    public float fuelTime = 5.5f;
    public float powerTime = 6.5f;

    private string abvValue;

    private void Awake()
    {
        InvokeRepeating("UpdateWood", 0, woodTime);
        InvokeRepeating("UpdateStone", 0, stoneTime);
        InvokeRepeating("UpdateMetal", 0, metalTime);
        InvokeRepeating("UpdateFuel", 0, fuelTime);
        InvokeRepeating("UpdatePower", 0, powerTime);
    }


    public void UpdateWood()
    {
        woodCur += 5.123f;

        if (woodCur > 1000 && woodCur < 1000000)
        {
            abvValue = "K";

            woodText.text = Math.Floor(woodCur / 1000).ToString("F0") + abvValue;
        }
        else if (woodCur >= 1000000 && woodCur < 1000000000)
        {
            abvValue = "M";

            woodText.text = Math.Floor(woodCur / 1000000).ToString("F0") + abvValue;
        }
        else if (woodCur >= 1000000000 && woodCur < 1000000000000)
        {
            abvValue = "B";

            woodText.text = Math.Floor(woodCur / 1000000000).ToString("F0") + abvValue;
        }
        else if (woodCur >= 1000000000000 && woodCur < 1000000000000000)
        {
            abvValue = "T";

            woodText.text = Math.Floor(woodCur / 1000000000000).ToString("0") + abvValue;
        }
        else if (woodCur >= 1000000000000000 && woodCur < 1000000000000000000)
        {
            abvValue = "a";

            woodText.text = Math.Floor(woodCur / 1000000000000000).ToString("0") + abvValue;
        }
        else if (woodCur >= 1000000000000000000 && woodCur < 1000000000000000000000f)
        {
            abvValue = "b";

            woodText.text = Math.Floor(woodCur / 1000000000000000000f).ToString("F0") + abvValue;
        }
        else if (woodCur >= 1000000000000000000000f && woodCur < 1000000000000000000000000f)
        {
            abvValue = "c";

            woodText.text = Math.Floor(woodCur / 1000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (woodCur >= 1000000000000000000000000f && woodCur < 1000000000000000000000000000f)
        {
            abvValue = "d";

            woodText.text = Math.Floor(woodCur / 1000000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (woodCur >= 1000000000000000000000000000f && woodCur < 1000000000000000000000000000000f)
        {
            abvValue = "e";

            woodText.text = Math.Floor(woodCur / 1000000000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (woodCur >= 1000000000000000000000000000000f && woodCur < 1000000000000000000000000000000000f)
        {
            abvValue = "f";

            woodText.text = Math.Floor(woodCur / 1000000000000000000000000000000f).ToString("F0") + abvValue;
        }
        else
        {
            woodText.text = woodCur.ToString("F0");
        }

    }
    public void UpdateStone()
    {
        stoneCur += 5.123f;

        if (stoneCur > 1000 && stoneCur < 1000000)
        {
            abvValue = "K";

            stoneText.text = Math.Floor(stoneCur / 1000).ToString("F0") + abvValue;
        }
        else if (stoneCur >= 1000000 && stoneCur < 1000000000)
        {
            abvValue = "M";

            stoneText.text = Math.Floor(stoneCur / 1000000).ToString("F0") + abvValue;
        }
        else if (stoneCur >= 1000000000 && stoneCur < 1000000000000)
        {
            abvValue = "B";

            stoneText.text = Math.Floor(stoneCur / 1000000000).ToString("F0") + abvValue;
        }
        else if (stoneCur >= 1000000000000 && stoneCur < 1000000000000000)
        {
            abvValue = "T";

            stoneText.text = Math.Floor(stoneCur / 1000000000000).ToString("0") + abvValue;
        }
        else if (stoneCur >= 1000000000000000 && stoneCur < 1000000000000000000)
        {
            abvValue = "a";

            stoneText.text = Math.Floor(stoneCur / 1000000000000000).ToString("0") + abvValue;
        }
        else if (stoneCur >= 1000000000000000000 && stoneCur < 1000000000000000000000f)
        {
            abvValue = "b";

            stoneText.text = Math.Floor(stoneCur / 1000000000000000000f).ToString("F0") + abvValue;
        }
        else if (stoneCur >= 1000000000000000000000f && stoneCur < 1000000000000000000000000f)
        {
            abvValue = "c";

            stoneText.text = Math.Floor(stoneCur / 1000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (stoneCur >= 1000000000000000000000000f && stoneCur < 1000000000000000000000000000f)
        {
            abvValue = "d";

            stoneText.text = Math.Floor(stoneCur / 1000000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (stoneCur >= 1000000000000000000000000000f && stoneCur < 1000000000000000000000000000000f)
        {
            abvValue = "e";

            stoneText.text = Math.Floor(stoneCur / 1000000000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (stoneCur >= 1000000000000000000000000000000f && stoneCur < 1000000000000000000000000000000000f)
        {
            abvValue = "f";

            stoneText.text = Math.Floor(stoneCur / 1000000000000000000000000000000f).ToString("F0") + abvValue;
        }
        else
        {
            stoneText.text = stoneCur.ToString("F0");
        }

    }
    public void UpdateMetal()
    {
        metalCur += 2.123f;

        if (metalCur > 1000 && metalCur < 1000000)
        {
            abvValue = "K";

            metalText.text = Math.Floor(metalCur / 1000).ToString("F0") + abvValue;
        }
        else if (metalCur >= 1000000 && metalCur < 1000000000)
        {
            abvValue = "M";

            metalText.text = Math.Floor(metalCur / 1000000).ToString("F0") + abvValue;
        }
        else if (metalCur >= 1000000000 && metalCur < 1000000000000)
        {
            abvValue = "B";

            metalText.text = Math.Floor(metalCur / 1000000000).ToString("F0") + abvValue;
        }
        else if (metalCur >= 1000000000000 && metalCur < 1000000000000000)
        {
            abvValue = "T";

            metalText.text = Math.Floor(metalCur / 1000000000000).ToString("0") + abvValue;
        }
        else if (metalCur >= 1000000000000000 && metalCur < 1000000000000000000)
        {
            abvValue = "a";

            metalText.text = Math.Floor(metalCur / 1000000000000000).ToString("0") + abvValue;
        }
        else if (metalCur >= 1000000000000000000 && metalCur < 1000000000000000000000f)
        {
            abvValue = "b";

            metalText.text = Math.Floor(metalCur / 1000000000000000000f).ToString("F0") + abvValue;
        }
        else if (metalCur >= 1000000000000000000000f && metalCur < 1000000000000000000000000f)
        {
            abvValue = "c";

            metalText.text = Math.Floor(metalCur / 1000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (metalCur >= 1000000000000000000000000f && metalCur < 1000000000000000000000000000f)
        {
            abvValue = "d";

            metalText.text = Math.Floor(metalCur / 1000000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (metalCur >= 1000000000000000000000000000f && metalCur < 1000000000000000000000000000000f)
        {
            abvValue = "e";

            metalText.text = Math.Floor(metalCur / 1000000000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (metalCur >= 1000000000000000000000000000000f && metalCur < 1000000000000000000000000000000000f)
        {
            abvValue = "f";

            stoneText.text = Math.Floor(metalCur / 1000000000000000000000000000000f).ToString("F0") + abvValue;
        }
        else
        {
            metalText.text = metalCur.ToString("F0");
        }

    }
    public void UpdateFuel()
    {
        fuelCur += 1.423f;

        if (fuelCur > 1000 && fuelCur < 1000000)
        {
            abvValue = "K";

            fuelText.text = Math.Floor(fuelCur / 1000).ToString("F0") + abvValue;
        }
        else if (fuelCur >= 1000000 && fuelCur < 1000000000)
        {
            abvValue = "M";

            fuelText.text = Math.Floor(fuelCur / 1000000).ToString("F0") + abvValue;
        }
        else if (fuelCur >= 1000000000 && fuelCur < 1000000000000)
        {
            abvValue = "B";

            fuelText.text = Math.Floor(fuelCur / 1000000000).ToString("F0") + abvValue;
        }
        else if (fuelCur >= 1000000000000 && fuelCur < 1000000000000000)
        {
            abvValue = "T";

            fuelText.text = Math.Floor(fuelCur / 1000000000000).ToString("0") + abvValue;
        }
        else if (fuelCur >= 1000000000000000 && fuelCur < 1000000000000000000)
        {
            abvValue = "a";

            fuelText.text = Math.Floor(fuelCur / 1000000000000000).ToString("0") + abvValue;
        }
        else if (fuelCur >= 1000000000000000000 && fuelCur < 1000000000000000000000f)
        {
            abvValue = "b";

            fuelText.text = Math.Floor(fuelCur / 1000000000000000000f).ToString("F0") + abvValue;
        }
        else if (fuelCur >= 1000000000000000000000f && fuelCur < 1000000000000000000000000f)
        {
            abvValue = "c";

            fuelText.text = Math.Floor(fuelCur / 1000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (fuelCur >= 1000000000000000000000000f && fuelCur < 1000000000000000000000000000f)
        {
            abvValue = "d";

            fuelText.text = Math.Floor(fuelCur / 1000000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (fuelCur >= 1000000000000000000000000000f && fuelCur < 1000000000000000000000000000000f)
        {
            abvValue = "e";

            fuelText.text = Math.Floor(fuelCur / 1000000000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (fuelCur >= 1000000000000000000000000000000f && fuelCur < 1000000000000000000000000000000000f)
        {
            abvValue = "f";

            fuelText.text = Math.Floor(fuelCur / 1000000000000000000000000000000f).ToString("F0") + abvValue;
        }
        else
        {
            fuelText.text = fuelCur.ToString("F0");
        }

    }
    public void UpdatePower()
    {
        powerCur += 1.123f;

        if (powerCur > 1000 && powerCur < 1000000)
        {
            abvValue = "K";

            powerText.text = Math.Floor(powerCur / 1000).ToString("F0") + abvValue;
        }
        else if (powerCur >= 1000000 && powerCur < 1000000000)
        {
            abvValue = "M";

            powerText.text = Math.Floor(powerCur / 1000000).ToString("F0") + abvValue;
        }
        else if (powerCur >= 1000000000 && powerCur < 1000000000000)
        {
            abvValue = "B";

            powerText.text = Math.Floor(powerCur / 1000000000).ToString("F0") + abvValue;
        }
        else if (powerCur >= 1000000000000 && powerCur < 1000000000000000)
        {
            abvValue = "T";

            powerText.text = Math.Floor(powerCur / 1000000000000).ToString("0") + abvValue;
        }
        else if (powerCur >= 1000000000000000 && powerCur < 1000000000000000000)
        {
            abvValue = "a";

            powerText.text = Math.Floor(powerCur / 1000000000000000).ToString("0") + abvValue;
        }
        else if (powerCur >= 1000000000000000000 && powerCur < 1000000000000000000000f)
        {
            abvValue = "b";

            powerText.text = Math.Floor(powerCur / 1000000000000000000f).ToString("F0") + abvValue;
        }
        else if (powerCur >= 1000000000000000000000f && powerCur < 1000000000000000000000000f)
        {
            abvValue = "c";

            powerText.text = Math.Floor(powerCur / 1000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (powerCur >= 1000000000000000000000000f && powerCur < 1000000000000000000000000000f)
        {
            abvValue = "d";

            powerText.text = Math.Floor(powerCur / 1000000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (powerCur >= 1000000000000000000000000000f && powerCur < 1000000000000000000000000000000f)
        {
            abvValue = "e";

            powerText.text = Math.Floor(powerCur / 1000000000000000000000000000f).ToString("F0") + abvValue;
        }
        else if (powerCur >= 1000000000000000000000000000000f && powerCur < 1000000000000000000000000000000000f)
        {
            abvValue = "f";

            powerText.text = Math.Floor(powerCur / 1000000000000000000000000000000f).ToString("F0") + abvValue;
        }
        else
        {
            powerText.text = powerCur.ToString("F0");
        }

    }

}

