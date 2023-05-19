using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryTabs : MonoBehaviour
{
    public GameObject tabButton1;
    public GameObject tabButton1a;
    public GameObject tabButton1b;
    public GameObject tabButton2;
    public GameObject tabButton3;

    public GameObject tabContent1;
    public GameObject tabContent1a;
    public GameObject tabContent1b;
    public GameObject tabContent2;
    public GameObject tabContent3;

    public GameObject tabClose;

    private bool Inventory = true;

    public void Start()
    {
        ToggleInventory();
    }
    public void ToggleInventory()
    {
        if (Inventory == true)
        {
            tabContent1.SetActive(false);
            tabContent2.SetActive(false);
            tabContent3.SetActive(false);
            tabButton1.SetActive(false);
            tabButton2.SetActive(false);
            tabButton3.SetActive(false);
            tabClose.SetActive(false);
            Inventory = false;
        }
        else
        {
            ShowTabMenu();
        }
    }
    public void HideAllTabs()
    {
        tabContent1.SetActive(false);
        tabContent2.SetActive(false);
        tabContent3.SetActive(false);
        tabButton1.SetActive(false);
        tabButton2.SetActive(false);
        tabButton3.SetActive(false);
        tabClose.SetActive(false);

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
        tabButton1.SetActive(true);
        tabButton2.SetActive(true);
        tabButton3.SetActive(true);
        tabClose.SetActive(false);
        Inventory = true;
    }
    public void ShowTab1()
    {
        HideAllTabs();
        tabContent1.SetActive(true);
        tabClose.SetActive(true);

    }
    public void ShowTab1a()
    {
        HideAllTabsInv();
        tabContent1a.SetActive(true);
        tabButton1a.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
        tabClose.SetActive(true);
    }
    public void ShowTab1b()
    {
        HideAllTabsInv();
        tabContent1b.SetActive(true);
        tabButton1b.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
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
}
