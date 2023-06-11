using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopIntroMusic : MonoBehaviour
{
    private void Start()
    {
        if (IntroMusic.Instance != null)
        {
            IntroMusic.Instance.StopEvent();
        }
    }
}