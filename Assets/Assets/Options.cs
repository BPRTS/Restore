using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject leftButton;
    public GameObject rightButton;
    private string leftOrRight = "right";

    private void OnDisable()
    {
        PlayerPrefs.SetString("ButtonSide", leftOrRight);
    }
    
    private void SetLeft()
    {
        leftOrRight = "Left";
        leftButton.SetActive(false);
        rightButton.SetActive(true);
    }
    private void SetRight()
    {
        leftOrRight = "Right";
        leftButton.SetActive(true);
        rightButton.SetActive(false);
    }
}
