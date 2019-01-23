using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game_Controller : MonoBehaviour {


    public class KeepScore
    {
        //Here we define our variables
        public int[] ThousandMax; //The [] is a array

        //When we create a new copy we can input these values. Note it's the class input
        //It has the same name as the class
        public KeepScore(int InThousands, int InHundreds, int InTens, int InOnes)
        {
            //Here we say how many items is in the array then what each is
            ThousandMax = new int[4];

            ThousandMax[0] = InThousands;//arrays start at 0 so our 4 array is 0-3
            ThousandMax[1] = InHundreds;
            ThousandMax[2] = InTens;
            ThousandMax[3] = InOnes;
        }
        //The above class now keeps the score
    }

    //We make a normal function to add the scores piece by piece
    public KeepScore AddTwoScores(KeepScore InScoreA, KeepScore InScoreB)
    {

        KeepScore OutScore = new KeepScore(0, 0, 0, 0);
        

        

        //Next we check if one value exceeds 9
        int IndexCounter = 0;
        foreach (int increment in OutScore.ThousandMax)
        {
            
                
                    OutScore.ThousandMax[IndexCounter] =
                InScoreA.ThousandMax[IndexCounter] + InScoreB.ThousandMax[IndexCounter];//Add the increment

            if (OutScore.ThousandMax[IndexCounter] > 9)
            {
                OutScore.ThousandMax[IndexCounter] -= 10;//if it does subtract 10
                if (IndexCounter > 0)
                { //Don't add if it is more than a thousand 0 is the first array item and is thousand
                    OutScore.ThousandMax[IndexCounter - 1] += 1; //Remember the larger number is lower in the array
                }

            }
            IndexCounter += 1;
        }

        return OutScore; //Return it as a score
    }
    //Lets make a string converter
    public string ScoreToString(KeepScore InScore)
    {
        string OutString = string.Format("{0}{1}{2}{3}" + "M", InScore.ThousandMax[0],
            InScore.ThousandMax[1], InScore.ThousandMax[2], InScore.ThousandMax[3]);
        return OutString;
    }


    public int MoneyIncome = 5;

    //now lets use what we made
    void Update()
    {//Unity calls this at the start
     //Make two scores
        KeepScore Player1Score = new KeepScore(0, 1, 5, MoneyIncome);
        KeepScore Player2Score = new KeepScore(0, 9, 0, 0);

        KeepScore Total = AddTwoScores(Player1Score, Player2Score);

        print(ScoreToString(Total)); 

        
    }
    
}

