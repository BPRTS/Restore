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
    private float Delay = 2f;
    


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



        //If New Quest
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
            //If Quest Active but not "new"
            {
                if (questCount > 0)
                {
                    GameObject.Find("QuestIndicator").GetComponent<Image>().sprite = questActiveIcon;
                }
                //if No Quest
                if (questCount == 0)
                {
                    transform.Find("QuestIndicator").GetComponent<Image>().sprite = questActiveIcon;
                }
            }
        }
    }

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
