using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public enum Weapons { ChangeWeaponsFromClubToStone, ChangeWeaponsFromStoneToClub }
public class InterfaceAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private Weapons currentWeapons;

  

    public void ChangeWeaponsAnimation(int mode)
    {
        if (mode == 0)
        {
            WeaponsPosition(Weapons.ChangeWeaponsFromStoneToClub);
        }
        else if (mode == 1)
        {
            WeaponsPosition(Weapons.ChangeWeaponsFromClubToStone);
        }

    }

    public void WeaponsPosition(Weapons newState)

    {
        //if (currentWeapons == newState) { return; }
        
            animator.Play(newState.ToString());
            currentWeapons = newState;
        

    }

}
