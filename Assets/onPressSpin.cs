using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onPressSpin : MonoBehaviour
{
    public GameObject row;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator pressSpin()
    {
        for (int i = 0; i < 30; i++)
        {
            if (row.transform.position.y >= 4)
                row.transform.position = new Vector2(row.transform.position.x, -5.3f);


            row.gameObject.transform.position = new Vector2(row.gameObject.transform.position.x, row.gameObject.transform.position.y + 1.5f);

            yield return new WaitForSeconds(.5f);
        }
    }

    public void elo()
    {
        StartCoroutine("pressSpin");
    }
}
