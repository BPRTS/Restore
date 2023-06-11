using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

public class NextScene : MonoBehaviour
{
    private void Start()
    {
        SceneManager.UnloadSceneAsync(0);
        SceneManager.UnloadSceneAsync(1);
    }
    public void OpenMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
        SceneManager.UnloadSceneAsync(2);
    }
}