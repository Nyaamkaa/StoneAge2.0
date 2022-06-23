using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAttackUIButtons : MonoBehaviour
{
    int currentMode = 0;
    [SerializeField] InterfaceAnimation interfaceAnimation;
    [SerializeField] private PlayerAnimation playerAnimation;

    public void Start()
    {
        //playerAnimation = GetComponent<PlayerAnimation>();
    }
    public void PressAttack(int mode)
    {
        Debug.Log("mode" + mode);
        Debug.Log("Currentmode" + currentMode);

        if (mode == 0 && currentMode == 1)
        {
            interfaceAnimation.ChangeWeaponsAnimation(0);
            currentMode = 0;
            Debug.Log("������� �� ������");
        }
        else if (mode == 0 && currentMode == 0)
        {
            //�����
            playerAnimation.PlayAttackAnimation();
            Debug.Log("������� �����");
        }
        else if (mode == 1 && currentMode == 0)
        {
            interfaceAnimation.ChangeWeaponsAnimation(1);
            currentMode = 1;
            Debug.Log("����� �� �������");
        }
        else if (mode == 1 && currentMode == 1)
        {
            //����� ������
            playerAnimation.PlayThrowAttackAnimation();
            Debug.Log("������ �����");
        }
      

    }
}

//���������� ���� ������� ������� ��� ������
//�������� ������ � �������