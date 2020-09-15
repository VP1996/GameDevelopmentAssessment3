using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
 
    public GameObject PacMan;

    private Tweener tweener;
    
    Animator m_Animator;

    Vector3 endPos;

    int movement;
 
   
    
    void Start()
    {
        PacMan = Instantiate(PacMan, new Vector3(4f, -6.4f, 0f), Quaternion.identity);
        m_Animator = PacMan.GetComponent<Animator>();
        endPos = new Vector3(1.28f, -6.4f, 0.0f);
        tweener = GetComponent<Tweener>();
        tweener.AddTween(PacMan.transform, PacMan.transform.position, endPos, 30f);
        movement = 0;
        m_Animator.SetBool("Left", true);
    }

    void Update()
    {
        if(PacMan.transform.position == endPos && movement == 0)
        {
            m_Animator.SetBool("Left", false);
            m_Animator.SetBool("Up", true);
            endPos = new Vector3(1.28f, -1.28f, 0.0f);
            tweener.AddTween(PacMan.transform, PacMan.transform.position, endPos, 30f);
            movement = 1;


        }
        else if (PacMan.transform.position == endPos && movement == 1)
        {
            m_Animator.SetBool("Up", false);
            m_Animator.SetBool("Right", true);
            endPos = new Vector3(7.679999f, -1.28f, 0.0f);
            tweener.AddTween(PacMan.transform, PacMan.transform.position, endPos, 30f);
            movement = 2;

        }
        else if (PacMan.transform.position == endPos && movement == 2)
        {
            m_Animator.SetBool("Right", false);
            m_Animator.SetBool("Down", true);
            endPos = new Vector3(7.679999f, -6.4f, 0.0f);
            tweener.AddTween(PacMan.transform, PacMan.transform.position, endPos, 30f);
            movement = 3;
        }
        else if (PacMan.transform.position == endPos && movement == 3)
        {
            m_Animator.SetBool("Down", false);
            m_Animator.SetBool("Left", true);
            endPos = new Vector3(1.28f, -6.4f, 0.0f);
            tweener.AddTween(PacMan.transform, PacMan.transform.position, endPos, 30f);
            movement = 0;
        }

    }
}
