using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestUI : MonoBehaviour
{
    public GameObject buttonQuests;
    public GameObject questScreen;
    public InventoryTabs invTabs;

    void Start()
    {
        buttonQuests.SetActive(true);
    }

    void Update()
    {
        
        if(!questScreen.activeSelf && !invTabs.activeInventory)
        {
            buttonQuests.SetActive(true);
        }
        else
        {
            buttonQuests.SetActive(false);
        }

    }

    public void OpenQuests()
    {
        questScreen.SetActive(true);
    }

    public void CloseQuests()
    {
        questScreen.SetActive(false);

    }

}
