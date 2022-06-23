using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Drinking : MonoBehaviour
{

    private int playerDrink;
    public int PlayerDrink { get; set; }


    private void Start()
    {
        print(playerDrink);
    }


    /* public int PlayerDrink
     {
        get
        {
           return playerDrink; 
        }

        set
        {
             playerDrink = value;
        }
     }
    */



    private PlayerColor playerColor;
    [SerializeField] private AngryWife angryWife;
    


    private void Awake()
    {
        playerColor = GetComponent<PlayerColor>();
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            angryWife.AngryScale(playerDrink);
            playerDrink++;
            print("Drink" + playerDrink);
            playerColor.ChangeColor(playerDrink);
             
        }
    }

   

}