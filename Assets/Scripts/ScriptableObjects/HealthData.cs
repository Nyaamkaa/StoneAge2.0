using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HealthData", menuName = "ScriptableObjacts/New Health", order = 0)]
public class HealthData : ScriptableObject
{
    [SerializeField] private Sprite healthSprite;
    public Sprite HealthSprite { get { return healthSprite; } }


    [SerializeField] private float healthValue;
    public float HealthValue { get { return healthValue; } }
}
