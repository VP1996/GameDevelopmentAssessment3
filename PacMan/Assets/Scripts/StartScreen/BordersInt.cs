using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BordersInt : MonoBehaviour
{
    public GameObject[] objects;
    float positionX = -17.2f;
    float positionY = 18.9f;
    float temp,temp2,temp3,temp4, temp5, temp6, temp7, temp8;
    public float timer = 0.0f;
    float x = 1.5f;
    float x1 = 1.21f;
    float y = 1.8f;
    public int count = 0;
    public int anothercount = 0;
    public int innercount = 0;

    void Start()
    {
              
        temp = positionX + x;
        temp2 = (positionX * -1) - x;
        temp3 = positionY - y;
        temp4 = (positionY * -1) + y;


        temp5 = positionX + 8*x1;
        temp6 = (positionX * -1) - 8 * x1;
        temp7 = positionY - 3*y;
        temp8 = positionY -y;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.11f)
        {

            if (count == 0)
            {
                var jeff0 = Instantiate(objects[0], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 0));
                var jeff1 = Instantiate(objects[0], new Vector3(positionX * -1, positionY * -1, 0), Quaternion.Euler(0, 0, 0));
                jeff0.transform.parent = gameObject.transform;
                jeff1.transform.parent = gameObject.transform;
                Destroy(jeff0, 2);
                Destroy(jeff1, 2);
                count += 1;
            }
            else if (count > 0 && count < 23)
            {
                var jeff0 = Instantiate(objects[1], new Vector3(temp, positionY, 0), Quaternion.Euler(0, 0, 0));
                var jeff1 = Instantiate(objects[1], new Vector3(temp2, positionY * -1, 0), Quaternion.Euler(0, 0, 0));
                jeff0.transform.parent = gameObject.transform;
                jeff1.transform.parent = gameObject.transform;
                Destroy(jeff0, 2);
                Destroy(jeff1, 2);
                temp += x;
                temp2 -= x;
                count += 1;

            }
            else if (count == 23)
            {
                var jeff0 = Instantiate(objects[0], new Vector3(temp, positionY, 0), Quaternion.Euler(0, 0, 0));
                var jeff1 = Instantiate(objects[0], new Vector3(temp2, positionY * -1, 0), Quaternion.Euler(0, 0, 0));
                jeff0.transform.parent = gameObject.transform;
                jeff1.transform.parent = gameObject.transform;
                Destroy(jeff0, 2);
                Destroy(jeff1, 2);
                count += 1;
            }
            else if (count >= 24 && count <= 43)
            {
                anothercount += 1;//24
                var jeff0 = Instantiate(objects[1], new Vector3(temp, temp3, 0), Quaternion.Euler(0, 0, 0));
                var jeff1 = Instantiate(objects[1], new Vector3(temp2, temp4, 0), Quaternion.Euler(0, 0, 0));
                jeff0.transform.parent = gameObject.transform;
                jeff1.transform.parent = gameObject.transform;
                Destroy(jeff0, 2);
                Destroy(jeff1, 2);
                temp3 -= y;
                temp4 += y;
                count += 1;
                

            }else if(count == 44) { restartBorder();}


            if (innercount == 0)
            {
                var jeff2 = Instantiate(objects[0], new Vector3(temp5, temp7, 0), Quaternion.Euler(0, 0, 0));
                var jeff3 = Instantiate(objects[0], new Vector3(temp6, temp8, 0), Quaternion.Euler(0, 0, 0));
                jeff2.transform.parent = gameObject.transform;
                jeff3.transform.parent = gameObject.transform;
                Destroy(jeff2, 0.6f);
                Destroy(jeff3, 0.6f);
                temp5 += x;
                temp6 -= x;
                innercount += 1;
            }else if (innercount > 0 && innercount < 10)
            {
                var jeff2 = Instantiate(objects[1], new Vector3(temp5, temp7, 0), Quaternion.Euler(0, 0, 0));
                var jeff3 = Instantiate(objects[1], new Vector3(temp6, temp8, 0), Quaternion.Euler(0, 0, 0));
                jeff2.transform.parent = gameObject.transform;
                jeff3.transform.parent = gameObject.transform;
                Destroy(jeff2, 0.6f);
                Destroy(jeff3, 0.6f);
                temp5 += x;
                temp6 -= x;
                innercount += 1;
            }
            else if (innercount == 10)
            {
                var jeff2 = Instantiate(objects[0], new Vector3(temp5, temp7, 0), Quaternion.Euler(0, 0, 0));
                var jeff3 = Instantiate(objects[0], new Vector3(temp6, temp8, 0), Quaternion.Euler(0, 0, 0));
                jeff2.transform.parent = gameObject.transform;
                jeff3.transform.parent = gameObject.transform;
                Destroy(jeff2, 0.6f);
                Destroy(jeff3, 0.6f);
                
                innercount += 1;
            }
            else if (innercount > 10 && innercount < 12)
            {
                temp7 += y;
                temp8 -= y;
                var jeff2 = Instantiate(objects[1], new Vector3(temp5, temp7, 0), Quaternion.Euler(0, 0, 0));
                var jeff3 = Instantiate(objects[1], new Vector3(temp6, temp8, 0), Quaternion.Euler(0, 0, 0));
                jeff2.transform.parent = gameObject.transform;
                jeff3.transform.parent = gameObject.transform;
                Destroy(jeff2, 0.6f);
                Destroy(jeff3, 0.6f);
                innercount += 1;
            }
            else if (innercount == 12)
            {
                restartinnerBorder();
            }





                timer = 0;
        }
    }
    public void restartBorder()
    {
        count = 0;
        anothercount = 0;
        timer = 0;
        temp = positionX + x;
        temp2 = (positionX * -1) - x;
        temp3 = positionY - y;
        temp4 = (positionY * -1) + y;
    }
    public void restartinnerBorder()
    {
        innercount = 0;
        temp5 = positionX + 8 * x1;
        temp6 = (positionX * -1) - 8 * x1;
        temp7 = positionY - 3 * y;
        temp8 = positionY - y;
    }

}
