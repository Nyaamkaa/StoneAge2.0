using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;

    void Awake()
    {
      rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void ThrowAttack(Vector2 direction, float force)
    {
        rigidbody2D.AddForce(direction * force);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       Debug.Log("Projectile Collision with " + collision.gameObject);
       Destroy(gameObject);
    }


    void Update()
    {
        
    }
}
