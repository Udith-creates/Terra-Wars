using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int health = 100;

    public bool hel=false;
    public GameObject deathEffect;
    public HealthBar healthBar;

    private int maxHealth;

    public GameOverScreen GameOverScreen;

    public GameObject;

    void Start()
    {
        maxHealth = health;

        if (healthBar != null)
        {
            healthBar.SetTarget(transform);
            healthBar.SetHealth(health, maxHealth);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (healthBar != null)
        {
            healthBar.SetHealth(health, maxHealth);
        }

        if (health <= 0)
        {
            hel=true;
            Die();
        }
    }

    public bool isDead = false;

    void Die()
    {
        if (hel)
        {
            GameObject.SetActive();
        }



        if (isDead) return;  // prevent double-call
        isDead = true;

        if (deathEffect != null)
            Instantiate(deathEffect, transform.position, Quaternion.identity);

        gameObject.SetActive(false);  // disable instead of destroy
    }
}