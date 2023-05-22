using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class PlayerCollisionAudio : MonoBehaviour
{
    public string soundEventPath = "event:/path/to/your/event";

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collision is with the object
        if (other.CompareTag("Player"))
        {
            // Play the FMOD event associated with the collision
            RuntimeManager.PlayOneShot(soundEventPath, transform.position);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
