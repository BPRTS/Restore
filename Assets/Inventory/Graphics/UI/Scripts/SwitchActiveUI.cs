using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchActiveUI : MonoBehaviour
{
    //Set game objects and sprites that will be used by the script

    public GameObject objectLeft;
    public GameObject objectRight;
    public Sprite activeLeft;
    public Sprite inactiveLeft;
    public Sprite activeRight;
    public Sprite inactiveRight;

    //when button is clicked, change it to the active sprite image and change the other button to inactive
    public void ClickLeftButton()
    {
        objectLeft.GetComponent<Image>().sprite = activeLeft;
        objectRight.GetComponent<Image>().sprite = inactiveRight;
    }
    public void ClickRightButton()
    {
        objectLeft.GetComponent<Image>().sprite = inactiveLeft;
        objectRight.GetComponent<Image>().sprite = activeRight;
    }

}
