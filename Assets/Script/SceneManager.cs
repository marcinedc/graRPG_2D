using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerCustom : MonoBehaviour
{
    public string[] locations;
    public string CurrentScene;

    public void LoadScene(string sceneName)
    {
        CurrentScene = sceneName;
        SceneManager.LoadScene(sceneName);
    }

    public void Transition(string nextScene)
    {
        LoadScene(nextScene);
    }
}