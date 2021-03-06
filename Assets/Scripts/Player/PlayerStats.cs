using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerStats : MonoBehaviour
{
    public PlayerHangerSlider playerHangerSlider;
    private float currentHunger = 10f;
    private float hunger;
    private float starvation = 0.3f;

    public int health;
    [SerializeField] private int numOfHearts;

    public Image[] hearts;
    [SerializeField] private Sprite fullHeart;
    [SerializeField] private Sprite emptyHeart;


    void Awake()
    {
        Hunger = currentHunger;
        playerHangerSlider.SetMaxHunger(Hunger);

    }


    void Update()
    {
        Hunger -= Time.deltaTime * starvation;
        playerHangerSlider.SetHunger(Hunger);
        HeartsHp();
   
    }

    public float Hunger
    {
        get
        {
            return hunger;
        }

        set
        {
            if (hunger < 0)
            {
                hunger = 0f;
               // health -= 1;
            }
            else if (hunger > 10.0f)
            {
                hunger = 10f;
            }
            else
            {
                hunger = value;
            }
        }

    }

    public void Satiety(float amount)
    {
        Hunger = Hunger + amount;
        
    }

    public void HeartsHp()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;

        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }

            else
            {
                hearts[i].enabled = false;
            }


        }
    }
}  

