using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Przejscie : MonoBehaviour
{
    public string sceneToLoad;         // Nazwa sceny do za³adowania
    public string destinationTag;      // Nazwa punktu startowego w nowej scenie

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerPrefs.SetString("SpawnPoint", destinationTag);
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
