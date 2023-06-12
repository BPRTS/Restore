using FMOD.Studio;
using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSFXFMOD : MonoBehaviour
{
    public Toggle sfxToggle;
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
        StartCoroutine(ToggleWithDelay());
    }

    private IEnumerator ToggleWithDelay()
    {
        float toggleValue = sfxToggle.isOn ? 1f : 0f;

        //Timer to change volume

        yield return new WaitForSeconds(0.1f);

        bus.setVolume(toggleValue);
    }
}
