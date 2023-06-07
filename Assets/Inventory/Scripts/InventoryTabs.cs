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
    public GameObject tabButton1a;
    public GameObject tabButton1b;
    public GameObject tabButton2;
    public GameObject tabButton3;
    public GameObject tabButton4;

    public GameObject tabContent1;
    public GameObject tabContent1a;
    public GameObject tabContent1b;
    public GameObject tabContent2;
    public GameObject tabContent3;


    public GameObject bgImage;
    public GameObject tabClose;
    public GameObject buttonSettings;
    public GameObject buttonHome;

    private bool Inventory = true;

    public void Start()
    {
        ToggleInventory();
        
    }

    public void Update()
    {
        if(Inventory)
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
        if (Inventory == true)
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
        Inventory = false;

    }
    public void HideAllTabsInv()
    {
        tabContent1a.SetActive(false);
        tabContent1b.SetActive(false);

        tabButton1a.GetComponent<Button>().image.color = new Color32(200, 200, 200, 255);
        tabButton1b.GetComponent<Button>().image.color = new Color32(200, 200, 200, 255);

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
        Inventory = true;
    }
    public void ShowTab1()
    {
        HideAllTabs();
        bgImage.SetActive(true);
        tabContent1.SetActive(true);
        tabClose.SetActive(true);

    }
    public void ShowTab1a()
    {
        HideAllTabsInv();
        bgImage.SetActive(true);
        tabContent1a.SetActive(true);
        tabButton1a.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
        tabClose.SetActive(true);
    }
    public void ShowTab1b()
    {
        HideAllTabsInv();
        bgImage.SetActive(true);
        tabContent1b.SetActive(true);
        tabButton1b.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
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
