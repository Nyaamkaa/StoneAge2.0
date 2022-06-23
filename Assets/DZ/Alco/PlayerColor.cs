using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerColor : MonoBehaviour
{

    [SerializeField] private Color [] color;
    private SpriteRenderer sp;
    
    

    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }


    public void ChangeColor(int playerDrink)
    {
        if   (playerDrink >= 20)
            sp.color = color[3];

        else if (playerDrink >= 15)
            sp.color = color[2];

        else if (playerDrink >= 10)
            sp.color = color[1];

        else if (playerDrink >= 5)
            sp.color = color[0];
    }

 
}

