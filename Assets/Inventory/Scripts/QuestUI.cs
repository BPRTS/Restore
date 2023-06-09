using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestUI : MonoBehaviour
{
    public GameObject buttonQuests;
    public GameObject questScreen;
    public InventoryTabs invTabs;
    public bool menuActive;

    void Start()
    {
        buttonQuests.SetActive(true);
    }

   public void Update()
    {
        
        if(!menuActive)
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
        menuActive = true;
    }

    public void CloseQuests()
    {
        questScreen.SetActive(false);
        menuActive = false;

    }

}
