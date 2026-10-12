using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i <= 31; i++)
        {
            if (i == 9)
            {
                Debug.Log("Its my birthday!");
            }
            else
            {
                Debug.Log(i);
            }
        }
    }

    void Update()
    {

    }
}