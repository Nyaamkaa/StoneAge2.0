using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour
{
    [SerializeField] private HealthData healthData;
    private SpriteRenderer spriteRenderer;
    [SerializeField] private PlayerStats playerStats;
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = healthData.HealthSprite;

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        PlayerMovement playerMovement = collider.GetComponent<PlayerMovement>();

        if (playerMovement != null)
        {
            playerStats.health += 1;
            Destroy(gameObject);
        }
    }
}
