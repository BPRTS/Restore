using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestUI : MonoBehaviour
{
    //(set at GameObject Quests)
    public GameObject buttonQuests;
    public GameObject questScreen;
    public InventoryTabs invTabs;
    public Sprite questActiveIcon;
    public Sprite noQuestIcon;

    private float Delay = 2f;
    public bool menuActive;
    private bool newQuest;
    private int questCount;



    void Start()
    {
        //Set Quest tracker button to active at start
        //questCount & newQuest should be overwritten in code, but setting as is for demo purposes
        questScreen.SetActive(false); 
        buttonQuests.SetActive(true);
        questCount = 1;
        newQuest = true;
        
    }

   public void Update()
    {
        if(newQuest)
        
        // check if the menu or quest window is active
/*        if(menuActive || invTabs.activeInventory)*/
    if(questScreen.activeSelf || invTabs.contentWindow.activeSelf)
        {
            buttonQuests.SetActive(false);
        }
        else
        {
            buttonQuests.SetActive(true);
        }


        //If New Quest, change icon to active and set timed animation
        if (newQuest)
        {
            GameObject.Find("QuestIndicator").GetComponent<Image>().sprite = questActiveIcon;
            Delay -= Time.deltaTime;

            if (Delay <= 0 && newQuest)
            {
                GameObject.Find("QuestIndicator").GetComponent<Animator>().Play("animate");
                Delay = 7f;

            }
        }
        else {
            if (!menuActive)
            //If Quest Active but not "new" make sure the icon is active
            //this is redundant because if it started with newQuest, then the sprite is already set
            //BUT we're at deadline and this works I think, so.. here it is
            {
                if (questCount > 0)
                {
                    GameObject.Find("QuestIndicator").GetComponent<Image>().sprite = questActiveIcon;
                }
                //if No Quest set quest icon to greyscale No Quest icon
                if (questCount == 0)
                {
                    transform.Find("QuestIndicator").GetComponent<Image>().sprite = questActiveIcon;
                }
            }
        }
    }

    // open quest UI screen 
    public void OpenQuests()
    {
        questScreen.SetActive(true);
        menuActive = true;
        newQuest = false;
        
    }

    public void CloseQuests()
    {
        questScreen.SetActive(false);
        menuActive = false;

    }

}
