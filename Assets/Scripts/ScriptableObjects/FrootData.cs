using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "FrootData", menuName ="ScriptableObjacts/New Froot", order = 0)]
public class FrootData : ScriptableObject

{
    [SerializeField] private Sprite frootSprite;
    public Sprite FrootSprite { get { return frootSprite; } }


   [SerializeField] private float frootValue;
   public float FrootValue { get{ return frootValue; } }

}
