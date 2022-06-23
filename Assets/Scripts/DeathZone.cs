using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameObject respawn;
    public PlayerStats playerStats;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Player")
        {
            other.transform.position = respawn.transform.position;
            playerStats.health -=1;
            
        }
    }
}
//collision.gameObject.
//collision.gameObject.tag