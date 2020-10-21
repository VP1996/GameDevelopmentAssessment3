using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    private float start, minutes, seconds, milliseconds;
    void Start()
    {
        start = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time - start;
        minutes = ((int)time / 60f)%60;
        seconds = (time % 60f);
        milliseconds = (time * 1000f) % 1000;

        timer.text = minutes.ToString("f0") + ":" + seconds.ToString("f0") + ":" + milliseconds.ToString("f0");




    }
}
