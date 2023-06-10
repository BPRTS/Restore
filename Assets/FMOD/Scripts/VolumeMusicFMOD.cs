using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;
using UnityEngine.UI;

public class VolumeMusicFMOD : MonoBehaviour
{
    public Slider volumeSlider;
    public string mixerGroupPath;  // Path to the Mixer Group in FMOD Studio
    public string parameterName;   // Name of the parameter controlling the volume

    private EventDescription eventDescription;
    private PARAMETER_ID parameterID;

    // Update is called once per frame
    void Start()
    {
        eventDescription = RuntimeManager.GetEventDescription(mixerGroupPath);
        eventDescription.getParameterDescriptionByName(parameterName, out PARAMETER_DESCRIPTION parameterDescription);
        parameterID = parameterDescription.id;
    }

    public void UpdateVolume()
    {
        float sliderValue = volumeSlider.value;
        RuntimeManager.StudioSystem.setParameterByID(parameterID, sliderValue);
    }
}
