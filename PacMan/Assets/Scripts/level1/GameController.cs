using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Ghosts;
    public GameObject Audio;
    public GameObject PacMan;
   

    void Start()
    {
        Audio.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Audio.GetComponent<AudioSource>().isPlaying)
        {
            Ghosts.SetActive(true);
            PacMan.SetActive(true);
        }
    }
}
