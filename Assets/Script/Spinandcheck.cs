using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spinandcheck : MonoBehaviour
{
    public float delayStart;
    float spinButtonPressTime;
    float spinButtonDelay = 3f;
    public Text betText;
    public Text balanceText;

    private void Start()
    {
        gameObject.tag = "Untagged";
    }

    IEnumerator pressSpin()
    {
        var betManager = FindObjectOfType<Betting>();
        int randomSpins = Random.Range(40, 60);
        if (randomSpins % 2 != 0)
        {
            randomSpins += 1;
        }
        for (int i = 0; i < randomSpins; i++)
        {
            if (gameObject.transform.position.y <= -14f)
                gameObject.transform.position = new Vector2(gameObject.transform.position.x, 16.8f);
            gameObject.gameObject.transform.position = new Vector2(gameObject.gameObject.transform.position.x, gameObject.gameObject.transform.position.y - 2.24f);
            yield return new WaitForSeconds(0.035f);
        }
        if (gameObject.transform.position.y < 17 && gameObject.transform.position.y > 13)
        {
            gameObject.tag = "Gem";
        }
        else if (gameObject.transform.position.y < 13 && gameObject.transform.position.y > 8)
        {
            gameObject.tag = "Lemon";
        }
        else if (gameObject.transform.position.y < 8 && gameObject.transform.position.y > 4)
        {
            gameObject.tag = "Cherry";
        }
        else if (gameObject.transform.position.y < 4 && gameObject.transform.position.y > -1)
        {
            gameObject.tag = "Seven";
        }
        else if (gameObject.transform.position.y < -1 && gameObject.transform.position.y > -5)
        {
            gameObject.tag = "Bar";
        }
        else if (gameObject.transform.position.y < -5 && gameObject.transform.position.y > -10)
        {
            gameObject.tag = "Watermelon";
        }
        else if (gameObject.transform.position.y < -10 && gameObject.transform.position.y > -13)
        {
            gameObject.tag = "Crown";
        }
        else if (gameObject.transform.position.y < -14)
        {
            gameObject.tag = "Gem";
        }
        betManager.WinCondition();
    }

    public void StartSpin()
    {
        StartCoroutine("pressSpin");
    }

    public void DelaySpin()
    {
        // cooldown before next press 
        if (spinButtonPressTime + spinButtonDelay > Time.unscaledTime || betText.text == 0.ToString() || balanceText.text == 0.ToString())
            return;
        spinButtonPressTime = Time.unscaledTime;
        Invoke("StartSpin", delayStart);
    }
}
