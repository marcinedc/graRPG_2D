using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int attack;
    public int defense;
    public string aiType;
    public Animator animator;

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
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