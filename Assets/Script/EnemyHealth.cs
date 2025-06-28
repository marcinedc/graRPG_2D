using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int Health = 3;
    
    private int currentHealth;

    private void Start()
    {
        currentHealth = Health;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Wróg pokonany!");
        Destroy(gameObject);
    }
}