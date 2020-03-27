using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void spinno()
    {
        for (int i = 0; i < 30; i++)
        {
            if (transform.position.y >= 4)
                transform.position = new Vector2(transform.position.x, -5.3f);


            gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 1.5f);

            
        }
    }

}
