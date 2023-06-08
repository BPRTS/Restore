using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestUI : MonoBehaviour
{
    public GameObject buttonQuests;
    public bool Quests;

    void Start()
    {
        buttonQuests.SetActive(true);
        Quests = false;
    }

    void Update()
    {
        if(Quests)
        {
            buttonQuests.SetActive(false);
        }
        else
        {
            buttonQuests.SetActive(true);
        }
    }
}
