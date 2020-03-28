using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onPressSpin : MonoBehaviour
{   
    public float delayStart;
    float m_LastPressTime;
    float m_PressDelay = 3f;

    public void delayed()
    {
        if (m_LastPressTime + m_PressDelay > Time.unscaledTime)
            return;
        m_LastPressTime = Time.unscaledTime;
        Invoke("elo", delayStart);
    }

    IEnumerator pressSpin()
    {
        {
            int randomSpins = Random.Range(40, 50);

            if (randomSpins % 2 != 0)
            {
                randomSpins += 1;
            }
            for (int i = 0; i < randomSpins; i++)
            {
                if (gameObject.transform.position.y <= -14)
                    gameObject.transform.position = new Vector2(gameObject.transform.position.x, 16.8f);
                gameObject.gameObject.transform.position = new Vector2(gameObject.gameObject.transform.position.x, gameObject.gameObject.transform.position.y - 2.25f);
                yield return new WaitForSeconds(0.04f);
            }
        }      
    }

    public void elo()
    {    
        StartCoroutine("pressSpin");

    }
}
