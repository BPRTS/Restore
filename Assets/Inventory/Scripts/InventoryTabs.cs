using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
using System.Runtime.CompilerServices;

public class InventoryTabs : MonoBehaviour
{
    public GameObject burgerbutton;

    public GameObject tabButton1;
    public GameObject tabButton2;
    public GameObject tabButton3;
    public GameObject tabButton4;

    public GameObject tabContent1;
    public GameObject tabContent2;
    public GameObject tabContent3;


    public GameObject bgImage;
    public GameObject tabClose;
    public GameObject buttonSettings;
    public GameObject buttonHome;

    public GameObject buttonQuests;

    public bool activeInventory = true;
    public QuestUI questUI;

    public void Start()
    {
        ToggleInventory();
        if (PlayerPrefs.GetString("ButtonSide") == "Right")
        {
            Debug.Log("Right");
            burgerbutton.transform.localPosition = new Vector3(390f, -901f, 0f);
        }
        else if (PlayerPrefs.GetString("ButtonSide") == "Left")
        {
            Debug.Log("Left");
            burgerbutton.transform.localPosition = new Vector3(-337f, -901f, 0f);
        }

    }

    public void Update()
    {
        if(activeInventory || questUI.questScreen.activeSelf)
        {
            burgerbutton.SetActive(false);
        }
        else
        {
            burgerbutton.SetActive(true);
        }


    }
    
    public void ToggleInventory()
    {
        if (activeInventory)
        {
            HideAllTabs();
        }
        else
        {
            ShowTabMenu();
        }
    }
    public void HideAllTabs()
    {
        bgImage.SetActive(false);
        tabContent1.SetActive(false);
        tabContent2.SetActive(false);
        tabContent3.SetActive(false);
        tabButton1.SetActive(false);
        tabButton2.SetActive(false);
        tabButton3.SetActive(false);
        tabButton4.SetActive(false);
        tabClose.SetActive(false);
        buttonSettings.SetActive(false);
        buttonHome.SetActive(false);
        activeInventory = false;

    }

    public void ShowTabMenu()
    {
        HideAllTabs();
        bgImage.SetActive(true);
        tabButton1.SetActive(true);
        tabButton2.SetActive(true);
        tabButton3.SetActive(true);
        tabButton4.SetActive(true);
        tabClose.SetActive(true);
        buttonSettings.SetActive(true);
        buttonHome.SetActive(true);
        activeInventory = true;
    }
    public void ShowTab1()
    {
        HideAllTabs();
        bgImage.SetActive(true);
        tabContent1.SetActive(true);
        tabClose.SetActive(true);

    }

    public void ShowTab2()
    {
        HideAllTabs();
        bgImage.SetActive(true);
        tabContent2.SetActive(true);
        tabClose.SetActive(true);

    }
    public void ShowTab3()
    {
        HideAllTabs();
        bgImage.SetActive(true);
        tabContent3.SetActive(true);
        tabClose.SetActive(true);
    }
    public void closeButton()
    { 
        if(tabButton1.activeSelf)
        {
            ToggleInventory();
        }
        else
        {
            ShowTabMenu();
        }
    }
    public void GoHome()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
