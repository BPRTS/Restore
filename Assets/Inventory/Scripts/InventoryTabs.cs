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

    
    public GameObject tabMenu;
    public GameObject tabContent1;
    public GameObject tabContent2;
    public GameObject tabContent3;
    public GameObject tabContent4;


    public GameObject tabClose;
    public GameObject buttonSettings;
    public GameObject buttonHome;

    public GameObject buttonQuests;

    public bool activeInventory = true;
    public QuestUI questUI;

    //FMOD TriggerPaths
    
    public string openInventoryEventPath;
    public string closeInventoryEventPath;

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
        if(!activeInventory)
        {
            burgerbutton.SetActive(true);
        }
        else
        {
            burgerbutton.SetActive(false);
        }


    }
    
    public void ToggleInventory()
    {
        if (activeInventory)
        {
            HideAllTabs();
            //FMOD Trigger Closing Inventory
            FMODUnity.RuntimeManager.PlayOneShot(closeInventoryEventPath, transform.position);
        }
        else
        {
            ShowTabMenu();
            //FMOD Trigger Opening Inventory
            FMODUnity.RuntimeManager.PlayOneShot(openInventoryEventPath, transform.position);
        }
    }
    public void HideAllTabs()
    {
        tabContent1.SetActive(false);
        tabContent2.SetActive(false);
        tabContent3.SetActive(false);
        tabContent4.SetActive(false);
        tabMenu.SetActive(false);
        tabClose.SetActive(false);
        buttonSettings.SetActive(false);
        buttonHome.SetActive(false);
        activeInventory = false;

    }

    public void ShowTabMenu()
    {
        HideAllTabs();
        tabMenu.SetActive(true);
        tabClose.SetActive(true);
        buttonSettings.SetActive(true);
        buttonHome.SetActive(true);
        activeInventory = true;
    }
    public void ShowTab1()
    {
        HideAllTabs();
        tabContent1.SetActive(true);
        tabClose.SetActive(true);

    }

    public void ShowTab2()
    {
        HideAllTabs();
        tabContent2.SetActive(true);
        tabClose.SetActive(true);

    }
    public void ShowTab3()
    {
        HideAllTabs();
        tabContent3.SetActive(true);
        tabClose.SetActive(true);
    }
    public void ShowTab4()
    {
        HideAllTabs();
        tabContent4.SetActive(true);
        tabClose.SetActive(true);
    }
    public void closeButton()
    { 
        if(tabMenu.activeSelf)
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
        SceneManager.LoadSceneAsync(1);
    }

}
