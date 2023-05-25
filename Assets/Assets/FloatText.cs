using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatText : MonoBehaviour
{
    #region Transform Variables
    private Transform collectObject;
    private Transform mainCam;
    private Transform worldSpaceCanvas;
    public Vector3 offset;
    #endregion

    void Start()
    {
        //Assigning variables to handle transforms for:
        //Camera, Object to collect, and Canvas where the text will be created.

        mainCam = Camera.main.transform;
        collectObject = transform.parent;
        worldSpaceCanvas = GameObject.FindGameObjectWithTag("WorldSpaceCanvas").transform;

        // setting the parent object to the canvas
        transform.SetParent(worldSpaceCanvas);
    }

    void Update()
    {
        // ALWAYS look at camera // face player
        transform.rotation = Quaternion.LookRotation(transform.position - mainCam.transform.position);

        // ALWAYS FOLLOW OBJECT POSITION
        // probably overkill since our objects are static?
        if (collectObject)
        {
            transform.position = collectObject.position + offset;
        }
    }
}
