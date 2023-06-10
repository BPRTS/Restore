using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;
using UnityEngine.UI;

public class VolumeMusicFMOD : MonoBehaviour
{
    public Slider volumeSlider;
    public string busPath;  // Path to the Bus in FMOD Studio
    public string parameterName;           // Name of the parameter controlling the volume

    private Bus bus;
    private float parameterID;

    private void Start()
    {
        bus = RuntimeManager.GetBus(busPath);
    }

    public void UpdateVolume()
    {
        float sliderValue = volumeSlider.value;
        bus.setVolume(sliderValue);
    }
}
