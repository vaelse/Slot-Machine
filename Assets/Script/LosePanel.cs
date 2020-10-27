using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LosePanel : MonoBehaviour
{
    public Text Balance;
    public Text Bet;
    public GameObject Panel;
    //restart game if your balance is equals to 0
    private void Update()
    {
        if (Balance.text == 0.ToString() && Bet.text == 0.ToString())
        {
            Invoke("active", 4f);
        }
    }
    public void active()
    {
        Panel.SetActive(true);
    }
    public void Onclick()
    {
        Balance.text = 500.ToString();
        Panel.SetActive(false);
    }
}
