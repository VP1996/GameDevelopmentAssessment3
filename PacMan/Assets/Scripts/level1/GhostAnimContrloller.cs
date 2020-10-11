using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAnimContrloller : MonoBehaviour
{
    Animator Ghost;

    private IEnumerator coroutine;
    void Start()
    {
        Ghost = gameObject.GetComponent<Animator>();
        Ghost.SetBool("Left", true);
        coroutine = WaitAndAnimate(3.0f);
        StartCoroutine(coroutine);

    }

    // Update is called once per frame
    void Update()
    {

       
    }

    private IEnumerator WaitAndAnimate(float waitTime)
    {
        while (true)
        {


            yield return new WaitForSeconds(waitTime);

            Ghost.SetBool("Left", false);
            Ghost.SetBool("Right", true);

            yield return new WaitForSeconds(waitTime);

            Ghost.SetBool("Right", false);
            Ghost.SetBool("Down", true);

            yield return new WaitForSeconds(waitTime);

            Ghost.SetBool("Down", false);
            Ghost.SetBool("Up", true);

            yield return new WaitForSeconds(waitTime);

            Ghost.SetBool("Up", false);
            Ghost.SetBool("Scared", true);

            yield return new WaitForSeconds(waitTime);

            Ghost.SetBool("Scared", false);
            Ghost.SetBool("Recovering", true);

            yield return new WaitForSeconds(waitTime);

            Ghost.SetBool("Recovering", false);
            Ghost.SetBool("Dead", true);

            yield return new WaitForSeconds(waitTime);

            Ghost.SetBool("Dead", false);
            Ghost.SetBool("Left", true);
        }
    
    
    }
}
