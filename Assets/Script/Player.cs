using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public string playerName;
    public int health;
    public int level;
    public List<Item> inventory = new List<Item>();
    public Animator animator;

    private void Update()
    {
        // Możliwość interakcji lub ataku
    }


}