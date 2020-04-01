using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Tags : MonoBehaviour
{
    void Update()
    {
        //switch (gameObject.transform.position.y)
        //{
        //    case  16.8f:
        //        gameObject.tag = "Gem";
        //        break;
        //    case 12.32f:
        //        gameObject.tag = "Lemon";
        //        break;
        //    case 7.84f:
        //        gameObject.tag = "Cherry";
        //        break;
        //    case 3.36f:
        //        gameObject.tag = "Seven";
        //        break;
        //    case -1.12f:
        //        gameObject.tag = "Watermelon";
        //        break;
        //    case -5.599999f:
        //        gameObject.tag = "Crown";
        //        break;
        //    case -10.08f:
        //        gameObject.tag = "Bar";
        //        break;
        //    case -14.56f:
        //        gameObject.tag = "Gem";
        //        break;
        //}
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
    }
}
