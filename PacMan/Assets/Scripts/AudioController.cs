using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource Strt;
    public AudioSource bckground;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!bckground.isPlaying)
        {
            if (!Strt.isPlaying)
            {

                bckground.Play();
            }
        }
    }
}
