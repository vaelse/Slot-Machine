using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class color : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("xdd");
    }

    IEnumerator xdd ()
    {
        
        for (int i = 0; i < 30; i++)
        {
            Color[] colors = { Color.red, Color.cyan, Color.yellow }; //etc
            int indx = Random.Range(0, colors.Length);
            var xd = gameObject.GetComponent<Text>().color = colors[indx];
            yield return new WaitForSeconds(0.5f);
        }


    }

}
