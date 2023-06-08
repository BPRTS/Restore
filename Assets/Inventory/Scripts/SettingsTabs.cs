using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsTabs : MonoBehaviour
{
    public GameObject settingsObject;
    public GameObject creditPanel;


    public GameObject leftButton;
    public GameObject rightButton;
    private string leftOrRight = "right";

    private void OnDisable()
    {
        PlayerPrefs.SetString("ButtonSide", leftOrRight);
    }

    public void SetLeft()
    {
        leftOrRight = "Left";

        //TODO: FIGURE THIS OUT

        // leftButton.SetActive(false);
        // rightButton.SetActive(true);
        //leftButton.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
        //rightButton.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    }
    public void SetRight()
    {
        leftOrRight = "Right";
        //leftButton.SetActive(true);
        //rightButton.SetActive(false);
       // rightButton.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        //leftButton.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);

    }
    public void Start()
    {
        {
            creditPanel.SetActive(false);
        }
    }
    public void closeCredits()
    {
        if(creditPanel)
        {
            creditPanel.SetActive(false);
            settingsObject.SetActive(true);
        }
    }

    public void showCredits()
    {
        settingsObject.SetActive(false);
        creditPanel.SetActive(true);
    }
}
