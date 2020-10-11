using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Tweeners : MonoBehaviour
{
    private Tweenees[] activeTween = new Tweenees[5];
    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int x = 0; x <= 4; x++) { 
            if (Vector3.Distance(activeTween[x].Target.position, activeTween[x].EndPos) > 0.1f)
            {
                


                float timeFraction = (Time.time - activeTween[x].StartTime) / activeTween[x].Duration;
                activeTween[x].Target.position = Vector3.Lerp(activeTween[x].Target.position, activeTween[x].EndPos, timeFraction);

            }

        if (Vector3.Distance(activeTween[x].Target.position, activeTween[x].EndPos) <= 0.1f)
        {
            activeTween[x].Target.position = activeTween[x].EndPos;
            activeTween[x] = null;
        }
    }
    }

    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration,int x)
    {
        
            if (activeTween[x] == null)
            {
                activeTween[x] = new Tweenees(targetObject, startPos, endPos, Time.time, duration);
            }
        
    }
}
