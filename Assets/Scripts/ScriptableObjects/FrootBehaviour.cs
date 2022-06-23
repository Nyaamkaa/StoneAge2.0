using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrootBehaviour : MonoBehaviour
{
   [SerializeField] private FrootData frootData;
   private SpriteRenderer spriteRenderer;
   [SerializeField] private PlayerStats playerStats;
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = frootData.FrootSprite;

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        PlayerMovement playerMovement = collider.GetComponent<PlayerMovement>();

        if (playerMovement != null)
        {
            playerStats.Satiety(frootData.FrootValue);
            Destroy(gameObject);
        }
    }


}
