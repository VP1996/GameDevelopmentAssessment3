using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolAnimation : MonoBehaviour
{
    public GameObject[] funObjects;

    //int size = 5;
    Tweeners tweener;

    Animator[] m_Animator = new Animator[5];

    Vector3[] left = new Vector3[5];
    Vector3[] right = new Vector3[5];

    int[] movement = new int[5];
    float duration = 300f;
    public float[] positionsX;

    void Start()
    {
        for (int x = 0; x <= 4; x++)
        {
            left[x] = new Vector3(positionsX[x], funObjects[x].transform.position.y, 0);
            right[x] = new Vector3(funObjects[x].transform.position.x, funObjects[x].transform.position.y, 0);
            
            m_Animator[x] = funObjects[x].GetComponent<Animator>();
            tweener = GetComponent<Tweeners>();
            tweener.AddTween(funObjects[x].transform, funObjects[x].transform.position, left[x], duration, x);
            movement[x] = 0;
            m_Animator[x].SetBool("Left", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        for (int x = 0; x <= 4; x++)
        {
            if (funObjects[x].transform.position == left[x] && movement[x] == 0)
            {
                m_Animator[x].SetBool("Left", false);
                m_Animator[x].SetBool("Right", true);
                tweener.AddTween(funObjects[x].transform, funObjects[x].transform.position, right[x], duration, x);
                movement[x] = 1;

            }
            else if (funObjects[x].transform.position == right[x] && movement[x] == 1)
            {
                m_Animator[x].SetBool("Right", false);
                m_Animator[x].SetBool("Left", true);
                tweener.AddTween(funObjects[x].transform, funObjects[x].transform.position, left[x], duration, x);
                movement[x] = 0;
                

            }
            
        }
        

    }
    

}
