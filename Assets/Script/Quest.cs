using UnityEngine;
using System.Collections.Generic;

public class Quest : MonoBehaviour
{
    public string description;
    public List<string> objectives;
    public Item reward;

    public bool IsComplete()
    {
        return objectives.Count == 0;
    }

    public void CompleteQuest(Player player)
    {
        player.inventory.Add(reward);
        Debug.Log("Quest ukończony!");
    }
}