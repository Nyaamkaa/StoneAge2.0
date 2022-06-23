using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataProperty : MonoBehaviour
{
    private string name;
    private int age;
    private int year = 2021;
    


    public string Name
    {
        get { return name; }
        set
        {
            if (value == "")
            {
                Debug.LogWarning("������ ������");
            }

            else
            {
                name = value;
            }

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= '0' && name[i] <= '9')
                {
                    Debug.LogWarning("������������ �������");
                }
            }
        } 
    }
    // ��������� ���������� � ������,� ��������� � ���

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 18)
            {
                Debug.LogWarning("�� ���������� �������");
            }
            else if (value == 0)
            {
                Debug.LogWarning("������������ ���� 0");
            }

            else
            {
                age = value;
            }
        }
    }


    private int Year
    {
       set
       {
         

       }
    }




}
    
    







  
