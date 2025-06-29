using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    void Start()
    {
        string spawnPoint = PlayerPrefs.GetString("SpawnPoint", "");

        if (!string.IsNullOrEmpty(spawnPoint))
        {
            GameObject spawnLocation = GameObject.FindWithTag(spawnPoint);
            GameObject player = GameObject.FindGameObjectWithTag("Player");

            if (spawnLocation != null && player != null)
            {
                player.transform.position = spawnLocation.transform.position;
            }
        }
    }
}
   

