using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchActiveUI : MonoBehaviour
{
    public GameObject objectLeft;
    public GameObject objectRight;
    public Sprite activeLeft;
    public Sprite inactiveLeft;
    public Sprite activeRight;
    public Sprite inactiveRight;

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
