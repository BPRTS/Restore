using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

public class NextScene : MonoBehaviour
{
    private void Start()
    {
        SceneManager.UnloadSceneAsync(1);
        SceneManager.UnloadSceneAsync(2);
    }
    public void OpenMainMenu()
    {
        SceneManager.LoadSceneAsync(1);
        SceneManager.UnloadSceneAsync(0);
    }


}