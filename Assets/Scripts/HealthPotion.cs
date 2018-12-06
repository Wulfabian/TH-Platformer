using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public float hpGive;
    PlayerHealth playerhealth;

    void Start()
    {
        playerhealth = FindObjectOfType<PlayerHealth>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && playerhealth.currentHealth < playerhealth.maxHealth)
        {
            playerhealth.currentHealth += hpGive;
            Destroy(gameObject);
        }
    }

}
