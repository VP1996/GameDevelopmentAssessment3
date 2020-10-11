using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FlashColor : MonoBehaviour
{
    public float timer = 0.0f;

    void Start()
    {
        GetComponent<Text>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
    void Update()
    {
        
        timer += Time.deltaTime;
        if (timer >= 1.0f)
        {
            for (int x = 0; x <= 1; x++)
            {
                GetComponent<Text>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            }
            timer = 0;
        }
    }

}
