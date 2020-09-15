using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] objects;
    int[,] MirrorlevelMap =
       {
        {7,2,2,2,2,2,2,2,2,2,2,2,2,1}
        ,{4,5,5,5,5,5,5,5,5,5,5,5,5,2}            
        ,{4,5,3,4,4,4,3,5,3,4,4,3,5,2}            
        ,{4,5,4,0,0,0,4,5,4,0,0,4,6,2}            
        ,{3,5,3,4,4,4,3,5,3,4,4,3,5,2}            
        ,{5,5,5,5,5,5,5,5,5,5,5,5,5,2}            
        ,{4,4,4,3,5,3,3,5,3,4,4,3,5,2}            
        ,{3,4,4,3,5,4,4,5,3,4,4,3,5,2}            
        ,{4,5,5,5,5,4,4,5,5,5,5,5,5,2}            
        ,{4,0,3,4,4,3,4,5,1,2,2,2,2,1}            
        ,{3,0,3,4,4,3,4,5,2,0,0,0,0,0}            
        ,{0,0,0,0,0,4,4,5,2,0,0,0,0,0}            
        ,{0,4,4,3,0,4,4,5,2,0,0,0,0,0}            
        ,{0,0,0,4,0,3,3,5,1,2,2,2,2,2}            
        ,{0,0,0,4,0,0,0,5,0,0,0,0,0,0}            
        ,{0,0,0,4,0,3,3,5,1,2,2,2,2,2}            
        ,{0,4,4,3,0,4,4,5,2,0,0,0,0,0}            
        ,{0,0,0,0,0,4,4,5,2,0,0,0,0,0}            
        ,{3,0,3,4,4,3,4,5,2,0,0,0,0,0}            
        ,{4,0,3,4,4,3,4,5,1,2,2,2,2,1}            
        ,{4,5,5,5,5,4,4,5,5,5,5,5,5,2}            
        ,{3,4,4,3,5,4,4,5,3,4,4,3,5,2}            
        ,{4,4,4,3,5,3,3,5,3,4,4,3,5,2}            
        ,{5,5,5,5,5,5,5,5,5,5,5,5,5,2}            
        ,{3,5,3,4,4,4,3,5,3,4,4,3,5,2}            
        ,{4,5,4,0,0,0,4,5,4,0,0,4,6,2}            
        ,{4,5,3,4,4,4,3,5,3,4,4,3,5,2}            
        ,{4,5,5,5,5,5,5,5,5,5,5,5,5,2}            
        ,{7,2,2,2,2,2,2,2,2,2,2,2,2,1}
    }            
;
    int[,] levelMap =
        {
            {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
            {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
            {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
            {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
            {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
            {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
            {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
            {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
            {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
            {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
            {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
            {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
            {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
            {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
            {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
            {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
            {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
            {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
            {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
            {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
            {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
            {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
            {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
            {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
            {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
            {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
            {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
            {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
            {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
    };

    float positionX = 0;
    float positionY = 0;

    void Start()
    {

        for (int i = 0; i <= 28; i++) {
            for (int x = 0; x <= 13; x++)
            {
                if (levelMap[i, x] == 0)
                {
                    Instantiate(objects[0], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 90));
                }
                if (levelMap[i, x] == 1)
                {
                    if (i == 9 && x == 0 || i == 28 && x == 0) 
                    { Instantiate(objects[1], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 180)); }
                    else if (i == 9 && x == 5 || i == 15 && x == 5) 
                    { Instantiate(objects[1], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 0)); }
                    else if (i == 13 && x == 5 || i == 19 && x == 5) 
                    { Instantiate(objects[1], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 270)); }
                    else 
                    { Instantiate(objects[1], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 90)); }
                }
                if (levelMap[i, x] == 2)
                {
                    if (i == 0 || i == 9 || i == 13 || i == 28 || i == 19 || i == 15) { Instantiate(objects[2], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 90)); }
                    else { Instantiate(objects[2], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 0)); }
                }
                
                
                if (levelMap[i, x] == 3)
                {
                    if (i == 2 && x == 2 || i == 2 && x == 7 || i == 6 && x == 2 || i == 6 && x == 7 || i == 6 && x == 10 || i == 12 && x == 10 || i == 10 && x == 8 || i == 15 && x == 7 || i == 19 && x == 8 || i == 18 && x == 13 || i == 21 && x == 2 || i == 21 && x == 10 || i == 24 && x == 2 || i == 24 && x == 7 || i == 24 && x == 13)
                    { Instantiate(objects[3], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 180)); }
                    else if (i == 2 && x == 5 || i == 2 && x == 11 || i == 6 && x == 5 || i == 6 && x == 8 || i == 7 && x == 13 || i == 9 && x == 11 || i == 15 && x == 8 || i == 18 && x == 11 || i == 21 && x == 5 || i == 24 && x == 5 || i == 24 && x == 11)
                    { Instantiate(objects[3], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 90)); }
                    else if (i == 4 && x == 2 || i == 4 && x == 7 || i == 4 && x == 13 || i == 7 && x == 2 || i == 7 && x == 7 || i == 7 && x == 10 || i == 9 && x == 8 || i == 13 && x == 7 || i == 10 && x == 13 || i == 16 && x == 10 || i == 18 && x == 8 || i == 22 && x == 2 || i == 22 && x == 7 || i == 22 && x == 10 || i == 26 && x == 2 || i == 26 && x == 7) 
                    { Instantiate(objects[3], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 270)); }
                    else { Instantiate(objects[3], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 0)); }
                }
                if (levelMap[i, x] == 4)
                {
                    if (i == 2 && x == 13 || i == 7 && x == 7 || i == 7 && x == 8 || i == 7 && x == 8 || i == 9 && x == 7 || i == 9 && x == 13 || i == 10 && x == 7 || i == 12 && x == 7 || i == 12 && x == 8||
                        i == 16 && x == 7 ||i == 16 && x == 8 || i == 18 && x == 7 || i == 19 && x == 7 || i == 19 && x == 13 || i == 21 && x == 7 || i == 21 && x == 8 || i == 26 && x == 13)
                    { Instantiate(objects[4], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 0)); }
                    else if (i == 2 || i == 4 || i == 6 || i == 7 || i == 9 || i == 10 || i == 12 || i == 16 || i == 18 || i == 19 || i == 21 || i == 22 || i == 9 || i == 24 || i == 26) 
                    { Instantiate(objects[4], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 90)); }
                    else { Instantiate(objects[4], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 0)); }
                }
                if (levelMap[i, x] == 5)
                {
                    Instantiate(objects[5], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 90));
                }
                if (levelMap[i, x] == 6)
                {
                    Instantiate(objects[6], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 90));
                }
                if (levelMap[i, x] == 7)
                {
                    if (i == 28) { GameObject newObject = Instantiate(objects[7], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 270)); newObject.transform.localScale = new Vector3(1, -1, 1); }
                    else { Instantiate(objects[7], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 90)); }
                }
                positionX = positionX + 1.28f;
                
            }
            positionY = positionY - 1.28f;
            positionX = 0;
        }
        positionX = 17.92F;
        positionY = 0;

        for (int i = 0; i <= 28; i++)
        {
            for (int x = 0; x <= 13; x++)
            {
                if (MirrorlevelMap[i, x] == 0)
                {
                    Instantiate(objects[0], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 90));
                }
                if (MirrorlevelMap[i, x] == 1)
                {
                    if (i == 9 && x == 8 || i == 15 && x == 8)
                    { Instantiate(objects[1], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 90)); }
                    else if (i == 0 && x == 13 || i == 19 && x == 13)
                     { Instantiate(objects[1], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 0)); }
                    else if (i == 13 && x == 8|| i == 13 && x == 8|| i == 19 && x == 8)
                    { Instantiate(objects[1], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 180)); }
                    else
                    { Instantiate(objects[1], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 270)); }
                }
                
                if (MirrorlevelMap[i, x] == 2)
                {
                    if (i == 0 || i == 9 || i == 13 || i == 28 || i == 19 || i == 15) { Instantiate(objects[2], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 90)); }
                    else { Instantiate(objects[2], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 0)); }
                }
                if (MirrorlevelMap[i, x] == 3)
                {
                    if (i == 2 && x == 2 || i == 2 && x == 8 || i == 6 && x == 5 || i == 6 && x == 8 || i == 7 && x == 0 || i == 9 && x == 2 || i == 15 && x == 5 || i == 18 && x == 2 || i == 21 && x == 8 || i == 24 && x == 8 || i == 24 && x == 2)
                        { Instantiate(objects[3], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 180)); }
                    else if (i == 2 && x == 6 || i == 2 && x == 11 || i == 6 && x == 3 || i == 6 && x == 6 || i == 6 && x == 11 || i == 10 && x == 5 || i == 12 && x == 3 || i == 15 && x == 6 || i == 18 && x == 0 || i == 19 && x == 5 || i == 21 && x == 3 || i == 21 && x == 11 || i == 24 && x == 11 || i == 24 && x == 0 || i == 24 && x == 6)
                    { Instantiate(objects[3], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 90)); }
                    else if (i == 4 && x == 2 || i == 4 && x == 8 || i == 7 && x == 8 || i == 10 && x == 2 || i == 13 && x == 5 || i == 19 && x == 2 || i == 21 && x == 0 || i == 22 && x == 5 || i == 22 && x == 8 || i == 26 && x == 8 || i == 26 && x == 2)
                    { Instantiate(objects[3], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 270)); }
                            else { Instantiate(objects[3], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 0)); }
                }
                if (MirrorlevelMap[i, x] == 4)
                {
                    if (i == 2 && x == 13 || i == 7 && x == 5 || i == 7 && x == 6 || i == 7 && x == 8 || i == 9 && x == 0 || i == 9 && x == 6 || i == 10 && x == 6 || i == 12 && x == 6 || i == 12 && x == 5 ||
                        i == 16 && x == 5 || i == 16 && x == 6 || i == 18 && x == 6 || i == 19 && x == 6 || i == 19 && x == 0 || i == 21 && x == 5 || i == 21 && x == 6 || i == 26 && x == 0|| i == 2 && x == 0)
                    { Instantiate(objects[4], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 0)); }
                    else if (i == 2 || i == 4 || i == 6 || i == 7 || i == 9 || i == 10 || i == 12 || i == 16 || i == 18 || i == 19 || i == 21 || i == 22 || i == 9 || i == 24 || i == 26)
                    { Instantiate(objects[4], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 90)); }
                    else { Instantiate(objects[4], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 0)); }
                }
                if (MirrorlevelMap[i, x] == 5)
                {
                    Instantiate(objects[5], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 90));
                }
                if (MirrorlevelMap[i, x] == 6)
                {
                    Instantiate(objects[6], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 90));
                }
                if (MirrorlevelMap[i, x] == 7)
                {
                    if (i == 0) { GameObject newObject = Instantiate(objects[7], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, 270)); newObject.transform.localScale = new Vector3(-1, 1, 1); }
                    else { Instantiate(objects[7], new Vector3(positionX, positionY, 0), Quaternion.Euler(0, 0, -90)); }
                }
                positionX = positionX + 1.28f;

            }
            positionY = positionY - 1.28f;
            positionX = 17.92F;
        }





    }    
        


    // Update is called once per frame
    void Update()
    {
        
    }
}
