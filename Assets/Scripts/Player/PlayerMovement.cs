using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public enum DR {Stop, Move}

[RequireComponent (typeof (Rigidbody2D)) ]
public class PlayerMovement : MonoBehaviour
{

    DR playerState;

    private PlayerAnimation playerAnimation;
    [SerializeField] private float playerSpeed;
    [SerializeField] private LayerMask layerGround;
    [SerializeField] private float jumpFroce;
    public int Direction { get; private set; }
    private Rigidbody2D rb;
    public GameObject projectilePrefab;
    Vector3 lookDirection = new Vector3(1, 0, 0);
    public bool IsGround { get; set; }
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<PlayerAnimation>();
    }


    private void FixedUpdate()
    {
        if (playerState == DR.Move)
        {
            rb.velocity = new Vector2(Direction * playerSpeed * Time.deltaTime, rb.velocity.y);
        }
        
    }


    private void OnTriggerEnter2D(Collider2D collider) // collider - С чем столкнулись.
    {
        if (((1 << collider.gameObject.layer) & layerGround) !=0)
        {
            IsGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {

        if (((1 << collider.gameObject.layer) & layerGround) != 0)
        {
            IsGround = false;
        }
    }

    public void MoveLeft()
    {
        transform.localScale =  new Vector3(-1f, transform.localScale.y, transform.localScale.z);
        Direction = -1;
        playerState = DR.Move;
    }

    public void MoveRigth()

    {
        transform.localScale = new Vector3(1f, transform.localScale.y, transform.localScale.z);
        Direction = 1;
        playerState = DR.Move;
    } 

    public void StopMoving()
    {
        Direction = 0;
        playerState = DR.Stop;
    }

    public void Jump()
    {
        if(IsGround) // isGroind == true.
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpFroce);
            IsGround = false;
            playerAnimation.PlayJumpAnimation();
        }

    }

  

   
    

    
}
