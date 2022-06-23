using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//MOI
public enum PlayerAnimationState {H_M_IDLE, H_M_WALK, H_M_JUMP, H_M_ATTACK, H_M_THROW}


public class PlayerAnimation : MonoBehaviour
{
    private Rigidbody2D rb;
    private PlayerMovement playerMovement;
    [SerializeField] private Animator animator;
    private bool isAttacking;
    private bool isAttackPressed;
    private bool isThrowAttacking;
    private bool isThrowAttackPressed;

    private PlayerAnimationState currentPlayerAnimationState;
    [SerializeField] private float attackDelay;




    void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();

    }


    void FixedUpdate()
    {
        if (playerMovement.IsGround && !isAttacking && !isThrowAttacking)
        {
            if (Mathf.Abs(playerMovement.Direction) != 0)
            {
                ChangeAnimationState(PlayerAnimationState.H_M_WALK);
            }
            else if (playerMovement.IsGround && !isAttacking && !isThrowAttacking)
            {
                ChangeAnimationState(PlayerAnimationState.H_M_IDLE);
            }

            else
            {
                PlayJumpAnimation();

            }
        }


        if (isAttackPressed)
        {
            
            isAttackPressed = false;
            if (!isAttacking)
            {
                isAttacking = true;
                Invoke("AttackComplite", attackDelay);
                ChangeAnimationState(PlayerAnimationState.H_M_ATTACK);
            }         
            
        }
        if (isThrowAttackPressed)
        {
            
            isThrowAttackPressed = false;
            if (!isThrowAttacking)
            {
                isThrowAttacking = true;
                Invoke("ThrowAttackComplite", attackDelay);
                ChangeAnimationState(PlayerAnimationState.H_M_THROW);
            }
            
           
        }
        

    }

    public void PlayAttackAnimation()
    {
        isAttackPressed = true;
    }

    public void AttackComplite()
    {
        isAttacking = false;

    }

    public void PlayThrowAttackAnimation()
    {
        isThrowAttackPressed = true;
    }
    public void ThrowAttackComplite()
    {
        isThrowAttacking = false;

    }
    
    public void PlayJumpAnimation()
    {
        ChangeAnimationState(PlayerAnimationState.H_M_JUMP);
    }


    private void ChangeAnimationState(PlayerAnimationState newState)
    {
        if (currentPlayerAnimationState == newState) { return; } //остановить одинаковую анимацию,повторный запуск анимации

        animator.Play(newState.ToString());

        currentPlayerAnimationState = newState;
    }


  /*  public void ChangeWeaponsAnimation(int mode)
    {
      if(mode == 0)
      {

      }
      else if(mode == 1)
      {

      }

    }
    */


}

// сделать скрипт для анимации интерфейса,там реализовать фуенкицию для воспроизведения смены кнопок
//создать скрипт для обрабоатки атаки или смены

