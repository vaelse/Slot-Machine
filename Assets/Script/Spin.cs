using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spin : MonoBehaviour
{   
    public float delayStart;
    float spinButtonPressTime;
    float spinButtonDelay = 3f;
    public Text betText;




    public void delayed()
    {
            if (spinButtonPressTime + spinButtonDelay > Time.unscaledTime || betText.text == 0.ToString())
                return;
        spinButtonPressTime = Time.unscaledTime;
        Invoke("elo", delayStart);
    }

    IEnumerator pressSpin()
    {
        {
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
                yield return new WaitForSeconds(0.03f);
            }
        }      
    }

    public void elo()
    {    
        StartCoroutine("pressSpin");

    }
}
