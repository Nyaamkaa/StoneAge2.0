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
    //свойства для создания банковскй карточки (ввод имени,с проверкой на пустую строчку и цифры)
    //ввод возраста регистрастарции с прверкой на 18 лет (- и 0 убираем)

    //задать год который сегодгня и свойство год оканчания дейсвтия карты(год выдачи +5лет)
    //получием свойство год оканчания дейсвтия карты(год выдачи +5лет)

    //задавать все свойства из внешнего срипта
    //нельзя получит свойства/значения там гед задаем

    //и вывести всю инфу о карте,в скрипте со свойствами
}
