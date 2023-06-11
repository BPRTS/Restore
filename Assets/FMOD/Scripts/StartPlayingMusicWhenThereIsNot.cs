using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StartPlayingMusicWhenThereIsNot : MonoBehaviour
{
    private void Start()
    {
        if (IntroMusic.Instance != null)
        {
            if (IntroMusic.Instance.IsStopped())
            {
                IntroMusic.Instance.StartEvent();
                Debug.Log("Event is Starting");
            }
            else
            {
                Debug.Log("Event did not start");
            }
        }
    }
}
