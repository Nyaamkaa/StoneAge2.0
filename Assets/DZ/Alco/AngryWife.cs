using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryWife : MonoBehaviour
{
    
    [SerializeField] private Drinking drinking;
    
    private int i;

    private void Start()
    {
      
        drinking.PlayerDrink = 5;
        print(drinking.PlayerDrink);
    }




    //public void AngryScale(int playerDrink)
    //{
    //    if ((playerDrink >= 3) && (playerDrink % 3) == 0)
    //    {
    //        transform.localScale += new Vector3(0.2f, 0.2f, 0);
    //    }
    //}


    public void AngryScale(int playerDrink)
    {
        i++;
        if ((playerDrink >= 3) && (i > 3))
        {   
            i = 0;
            transform.localScale += new Vector3(0.2f, 0.2f, 0);
        }
    }
    //�������� ��� �������� ��������� �������� (���� �����,� ��������� �� ������ ������� � �����)
    //���� �������� ��������������� � �������� �� 18 ��� (- � 0 �������)

    //������ ��� ������� �������� � �������� ��� ��������� �������� �����(��� ������ +5���)
    //�������� �������� ��� ��������� �������� �����(��� ������ +5���)

    //�������� ��� �������� �� �������� ������
    //������ ������� ��������/�������� ��� ��� ������

    //� ������� ��� ���� � �����,� ������� �� ����������
}
