using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DN {Day, Nigth}

public class Enum : MonoBehaviour
{

    public DN dnKiev = DN.Day;
    DN dnNewYork = DN.Nigth;

    float dayTime = 12;
    float time;


    void Start()
    {

       
    }
    void Update()
    {
        if (Time.time > dayTime)

        {
            dnKiev = DN.Nigth;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            dnKiev = DN.Day;
            dayTime += Time.time;
        }

        if (dnKiev == DN.Day)

        {
            print("Магазин открыт");
        }

        else
        {
            print("Клуб открыт");
        }
    }
}
