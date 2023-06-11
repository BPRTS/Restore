using UnityEngine;
using FMOD.Studio;

public class IntroMusic : MonoBehaviour
{
    public string eventName; // The name or path of the FMOD event

    private EventInstance eventInstance;

    private static IntroMusic instance;

    public static IntroMusic Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        // Ensure only one instance of FMODManager exists in the scene
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        DontDestroyOnLoad(gameObject);

        // Create an instance of the FMOD event
        eventInstance = FMODUnity.RuntimeManager.CreateInstance(eventName);

        // Start playing the FMOD event
        eventInstance.start();
    }

    public void StopEvent()
    {
        // Stop the FMOD event
        eventInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }

    private void OnDestroy()
    {
        // Release the FMOD event instance when the GameObject is destroyed
        eventInstance.release();
    }
}

