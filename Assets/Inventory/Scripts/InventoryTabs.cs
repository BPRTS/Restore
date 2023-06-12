using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
using System.Runtime.CompilerServices;

public class InventoryTabs : MonoBehaviour
{
    public TutorialSequence tutorialSequence;
    public Canvas maincanvas;

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

    public bool activeInventory;
    public GameObject contentWindow;

   /* public bool questsAppear = false;*/

    //FMOD TriggerPaths
    
    public string openInventoryEventPath;
    public string closeInventoryEventPath;

    public void Start()
    {
        //ToggleInventory();
    }


    
    public void ToggleInventory()
    {
        if (activeInventory)
        {
            Debug.Log("I am Open!");
            HideAllTabs();

          /*  if (tutorialSequence.stage == 3)
            {
                questsAppear = true;
            }*/
            //FMOD Trigger Closing Inventory
            FMODUnity.RuntimeManager.PlayOneShot(closeInventoryEventPath, transform.position);
        }
        else
        {
            Debug.Log("I am closed!");
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
        contentWindow.SetActive(false);
        activeInventory = false;

       /* if(questsAppear)
        {
            maincanvas.transform.GetChild(2).gameObject.SetActive(true);
        }*/
    }

    public void ShowTabMenu()
    {
        HideAllTabs();
        contentWindow.SetActive(true);
        tabMenu.SetActive(true);
        tabClose.SetActive(true);
        buttonSettings.SetActive(true);
        buttonHome.SetActive(true);
        contentWindow.SetActive(true);
        activeInventory = true;
    }
    public void ShowTab1()
    {
        if(tutorialSequence.stage == 2)
        {
            tutorialSequence.stage = 3;
        }
        HideAllTabs();
        tabContent1.SetActive(true);
        tabClose.SetActive(true);
        contentWindow.SetActive(true);

    }

    public void ShowTab2()
    {
        HideAllTabs();
        tabContent2.SetActive(true);
        tabClose.SetActive(true);
        contentWindow.SetActive (true);

    }
    public void ShowTab3()
    {
        HideAllTabs();
        tabContent3.SetActive(true);
        tabClose.SetActive(true);

        contentWindow.SetActive(true);  

    }
    public void ShowTab4()
    {
        HideAllTabs();
        tabContent4.SetActive(true);
        tabClose.SetActive(true);
        contentWindow.SetActive(true);
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
