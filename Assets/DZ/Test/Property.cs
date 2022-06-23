using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : MonoBehaviour
{
       public string Name { get; private set; }

    private int age;
    public int Age
    {
        get { return age; }

        set 
        {
            if( value <0)
            { 
            age = value*-1;
            }
            else if(value ==0)
            {
                Debug.LogWarning("Пользователь ввел 0");
            }
            else
            {
                age = value;
            }
        }


    }







    void Start()
    {
        Age = 55;
        print(age);
    }

    void Update()
    {
        
    }


}
