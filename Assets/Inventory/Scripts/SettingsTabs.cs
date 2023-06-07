using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsTabs : MonoBehaviour
{
    public GameObject settingsObject;
    public GameObject creditPanel;

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
