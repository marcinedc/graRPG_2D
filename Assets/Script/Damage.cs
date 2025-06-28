using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private int AmountofDamage = 1;

   private void OnTriggerEnter2D(Collider2D other)
   {
    Debug.Log("Miecz trafił obiekt: " + other.name);

        EnemyHealth enemyHealth = other.GetComponentInParent<EnemyHealth>();
        if (enemyHealth != null)
        {
            Debug.Log("Trafiony obiekt: " + other.gameObject.name + " | Layer: " + other.gameObject.layer);
            enemyHealth.TakeDamage(AmountofDamage);
        }
        else
        {
            Debug.Log("Obiekt nie ma EnemyHealth.");
        }
   }
}
