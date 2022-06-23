using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHangerSlider : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private PlayerStats playerStats;

   public void SetMaxHunger(float hunger)
    {
        slider.maxValue = playerStats.Hunger;
        

    }
    public void SetHunger(float hunger)
    {
        slider.value = playerStats.Hunger;
    }

}
