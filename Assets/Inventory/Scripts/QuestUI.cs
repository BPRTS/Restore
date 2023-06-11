using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestUI : MonoBehaviour
{
    public GameObject buttonQuests;
    public GameObject questScreen;
    public InventoryTabs invTabs;
    public bool menuActive;
    public bool newQuest;
    public int questCount;
    public Sprite questActiveIcon;
    public Sprite noQuestIcon;
    private float Delay = 15f;


    void Start()
    {
        buttonQuests.SetActive(true);
        questCount = 1;
        newQuest = true;
    }

   public void Update()
    {
        
        if(menuActive)
        {
            buttonQuests.SetActive(false);
        }
        else
        {
            buttonQuests.SetActive(true);
        }

        Delay -= Time.deltaTime;

        if (Delay <= 0 && newQuest)
        {
            transform.Find("QuestIndicator").GetComponent<Animation>().Play("NewQuest");
            Delay = 3f;
        }

/*        //If New Quest
        if (newQuest)
        { 
            transform.Find("QuestIndicator").GetComponent<Image>().sprite = questActiveIcon;
            //plus animation
        }

        //If Quest Active but not "new"
        if(questCount>0)
        { 
        transform.Find("QuestIndicator").GetComponent<Image>().sprite = questActiveIcon;
        }
        //if No Quest
        if (questCount == 0)
        {
            transform.Find("QuestIndicator").GetComponent<Image>().sprite = questActiveIcon;
        }*/
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
