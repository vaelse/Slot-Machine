using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Betting : MonoBehaviour
{
    public GameObject[] Rows;
    public Text Bet;
    public Text Balance;
    public Text Won;
    float increaseBet = 5;
    float initialBet = 0;
    float initialBalance = 500;
    float initialWin = 0;
    float spinButtonPressTime;
    float spinButtonDelay = 3f;
    float winMutliplier;
    bool xd = true; 

    private void Update()
    {      
        if(xd == true)
        {
            WinCondition();
            initialBalance += initialWin;
            xd = false;
        }
        Bet.text = initialBet.ToString();
        Balance.text = initialBalance.ToString();
    }

    public void IncreaseBet()
    {
        initialBet += increaseBet;
    }
    public void SubtractBet()
    {
        if (initialBet > 0)
        initialBet -= increaseBet;
    }

    public void SpinCost()
    {
        initialWin = 0;
        if (spinButtonPressTime + spinButtonDelay > Time.unscaledTime)
            return;
        spinButtonPressTime = Time.unscaledTime;
        initialBalance -= initialBet;
    }

    public void WinCondition()
    {
            if (Rows[0].tag == "Lemon" && Rows[1].tag == "Lemon" && Rows[2].tag == "Lemon")
            {
                winMutliplier = 1.2f;
            xd = true;
            }
            else if ((Rows[0].tag == "Lemon" && Rows[1].tag == "Lemon") || (Rows[1].tag == "Lemon" && Rows[2].tag == "Lemon") || (Rows[0].tag == "Lemon" && Rows[2].tag == "Lemon"))
            {
                winMutliplier = 2f;
            xd = true;
        }
            else if ((Rows[0].tag == "Gem" && Rows[1].tag == "Gem") || (Rows[1].tag == "Gem" && Rows[2].tag == "Gem") || (Rows[0].tag == "Gem" && Rows[2].tag == "Gem"))
            {
                winMutliplier = 1.4f;
            xd = true;
        }
            else if (Rows[0].tag == "Gem" && Rows[1].tag == "Gem" && Rows[2].tag == "Gem")
            {
                winMutliplier = 2.5f;
            xd = true;
        }
            else if ((Rows[0].tag == "Cherry" && Rows[1].tag == "Cherry") || (Rows[1].tag == "Cherry" && Rows[2].tag == "Cherry") || (Rows[0].tag == "Cherry" && Rows[2].tag == "Cherry"))
            {
                winMutliplier = 1.6f;
            xd = true;
        }
            else if (Rows[0].tag == "Cherry" && Rows[1].tag == "Cherry" && Rows[2].tag == "Cherry")
            {
                winMutliplier = 3f;
            xd = true;
        }
            else if ((Rows[0].tag == "Watermelon" && Rows[1].tag == "Watermelon") || (Rows[1].tag == "Watermelon" && Rows[2].tag == "Watermelon") || (Rows[0].tag == "Watermelon" && Rows[2].tag == "Watermelon"))
            {
                winMutliplier = 1.8f;
            xd = true;
        }
            else if (Rows[0].tag == "Watermelon" && Rows[1].tag == "Watermelon" && Rows[2].tag == "Watermelon")
            {
                winMutliplier = 3.5f;
            xd = true;
        }
            else if ((Rows[0].tag == "Crown" && Rows[1].tag == "Crown") || (Rows[1].tag == "Crown" && Rows[2].tag == "Crown") || (Rows[0].tag == "Crown" && Rows[2].tag == "Crown"))
            {
                winMutliplier = 2f;
            xd = true;
        }
            else if (Rows[0].tag == "Crown" && Rows[1].tag == "Crown" && Rows[2].tag == "Crown")
            {
                winMutliplier = 4f;
            xd = true;
        }
            else if ((Rows[0].tag == "Seven" && Rows[1].tag == "Seven") || (Rows[1].tag == "Seven" && Rows[2].tag == "Seven") || (Rows[0].tag == "Seven" && Rows[2].tag == "Seven"))
            {
                winMutliplier = 2.2f;
            xd = true;
        }
            else if (Rows[0].tag == "Seven" && Rows[1].tag == "Seven" && Rows[2].tag == "Seven")
            {
                winMutliplier = 4.5f;
            xd = true;
        }
            else if ((Rows[0].tag == "Bar" && Rows[1].tag == "Bar") || (Rows[1].tag == "Bar" && Rows[2].tag == "Bar") || (Rows[0].tag == "Bar" && Rows[2].tag == "Bar"))
            {
                winMutliplier = 2.4f;
            xd = true;
        }
            else if (Rows[0].tag == "Bar" && Rows[1].tag == "Bar" && Rows[2].tag == "Bar")
            {
                winMutliplier = 5f;
            xd = true;
        }

        initialWin = initialBet * winMutliplier;
        Won.text = initialWin.ToString();
    }
}

