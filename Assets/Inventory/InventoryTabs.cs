using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryTabs : MonoBehaviour
{
    public GameObject tabbutton1;
    public GameObject tabbutton1a;
    public GameObject tabbutton1b;
    public GameObject tabbutton2;
    public GameObject tabbutton3;

    public GameObject tabcontent1;
    public GameObject tabcontent1a;
    public GameObject tabcontent1b;
    public GameObject tabcontent2;
    public GameObject tabcontent3;

    private bool Inventory = true;

    public void Start()
    {
        ToggleInventory();
    }
    public void ToggleInventory()
    {
        if (Inventory == true)
        {
            tabcontent1.SetActive(false);
            tabcontent2.SetActive(false);
            tabcontent3.SetActive(false);
            tabbutton1.SetActive(false);
            tabbutton2.SetActive(false);
            tabbutton3.SetActive(false);
            Inventory = false;
        }
        else
        {
            tabcontent1.SetActive(true);
            tabbutton1.SetActive(true);
            tabbutton2.SetActive(true);
            tabbutton3.SetActive(true);
            Inventory = true;
        }
    }
    public void HideAllTabs()
    {
        tabcontent1.SetActive(false);
        tabcontent2.SetActive(false);
        tabcontent3.SetActive(false);

        tabbutton1.GetComponent<Button>().image.color = new Color32(200, 200, 200, 255);
        tabbutton2.GetComponent<Button>().image.color = new Color32(200, 200, 200, 255);
        tabbutton3.GetComponent<Button>().image.color = new Color32(200, 200, 200, 255);
    }
    public void HideAllTabsInv()
    {
        tabcontent1a.SetActive(false);
        tabcontent1b.SetActive(false);

        tabbutton1a.GetComponent<Button>().image.color = new Color32(200, 200, 200, 255);
        tabbutton1b.GetComponent<Button>().image.color = new Color32(200, 200, 200, 255);

    }

    public void ShowTab1()
    {
        HideAllTabs();
        tabcontent1.SetActive(true);
        tabbutton1.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
    }
    public void ShowTab1a()
    {
        HideAllTabsInv();
        tabcontent1a.SetActive(true);
        tabbutton1a.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
    }
    public void ShowTab1b()
    {
        HideAllTabsInv();
        tabcontent1b.SetActive(true);
        tabbutton1b.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
    }
    public void ShowTab2()
    {
        HideAllTabs();
        tabcontent2.SetActive(true);
        tabbutton2.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
    }
    public void ShowTab3()
    {
        HideAllTabs();
        tabcontent3.SetActive(true);
        tabbutton3.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
    }
}
