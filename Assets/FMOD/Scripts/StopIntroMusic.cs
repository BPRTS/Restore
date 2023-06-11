using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopIntroMusic : MonoBehaviour
{
    public string sceneToStopMusic; // Name of the scene where you want to stop the IntroMusic event

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == sceneToStopMusic)
        {
            StartCoroutine(StopIntroMusicCoroutine());
        }
    }

    private IEnumerator StopIntroMusicCoroutine()
    {
        yield return new WaitForSeconds(0.1f); // Adjust the delay as needed

        if (IntroMusic.Instance != null)
        {
            IntroMusic.Instance.StopEvent();
        }
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}