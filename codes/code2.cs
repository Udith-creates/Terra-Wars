using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int health = 100;
    public bool hel = false;

    public GameObject deathEffect;
    public HealthBar healthBar;

    private int maxHealth;

    public GameObject gameOverScreen;  // Reference to Game Over UI

    public bool isDead = false;

    void Start()
    {
        maxHealth = health;

        if (healthBar != null)
        {
            healthBar.SetTarget(transform);
            healthBar.SetHealth(health, maxHealth);
        }

        if (gameOverScreen != null)
            gameOverScreen.SetActive(false); // Hide Game Over screen at start
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (healthBar != null)
        {
            healthBar.SetHealth(health, maxHealth);
        }

        if (health <= 0 && !isDead)
        {
            hel = true;
            Die();
        }
    }

    void Die()
    {
        if (hel && gameOverScreen != null)
        {
            gameOverScreen.SetActive(true); // Show Game Over screen
        }

        if (isDead) return;
        isDead = true;

        if (deathEffect != null)
            Instantiate(deathEffect, transform.position, Quaternion.identity);

        gameObject.SetActive(false); // Disable the player
    }
}