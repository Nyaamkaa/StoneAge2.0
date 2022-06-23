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
            Debug.Log("Дубинка на камень");
        }
        else if (mode == 0 && currentMode == 0)
        {
            //атака
            playerAnimation.PlayAttackAnimation();
            Debug.Log("Дубинка атака");
        }
        else if (mode == 1 && currentMode == 0)
        {
            interfaceAnimation.ChangeWeaponsAnimation(1);
            currentMode = 1;
            Debug.Log("Кмень на дубинку");
        }
        else if (mode == 1 && currentMode == 1)
        {
            //атака камнем
            playerAnimation.PlayThrowAttackAnimation();
            Debug.Log("Камень атака");
        }
      

    }
}

//Посмотреть урок андроид хелепер юай амации
//доделкть плоску с голодом