using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Betting : MonoBehaviour
{
    public Text Bet;
    public Text Balance;
    public Text Won;
    int increaseBet = 5;
    int initialBet = 0;
    int initialBalance = 500;
    int initialWin = 0;
    float spinButtonPressTime;
    float spinButtonDelay = 3f;

    private void Update()
    {
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
        if (spinButtonPressTime + spinButtonDelay > Time.unscaledTime)
            return;
        spinButtonPressTime = Time.unscaledTime;
        initialBalance -= initialBet;
    }
}
