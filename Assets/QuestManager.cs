using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    
    [Header("Quest Variables")]
    public PopUpWindow popUpWindow;
    public InventoryObject inventory;

    [Header("Bottle Quest")]
    public Toggle bottleQuest;
    public ItemObject q01Reward;
    public int q01RewardAmt;
    private bool bottleComplete;
    public InventorySlot bottleItem;
    private bool q1Complete = false;

    [Header("Repair Oxygen")]
    public ItemObject q02Reward;
    public int q02RewardAmt;

    [Header("Craft an Item")]
    public ItemObject q03Reward;
    public int q03RewardAmt;

    private int amount = 0;
    private string questName = "Empty! Change this in script.";
    //TODO CALL THIS 


    public void BottleQuest()
    {
        //bool states IF amount in inventory > 0, logic on BottleCheck() method
        if(bottleComplete)
        {
            bottleQuest.isOn = true;
            questName = "Collect Bottles";

            inventory.AddItem(new Item(q01Reward), 1);
            if (!q1Complete)
            {
                popUpWindow.AddToQueue($"{questName} Quest Complete! You have gotten {q01RewardAmt} {q01Reward.itemName}");
                q1Complete = true;
            }
        }

    }
   public void RepairOxygen()
    {
        inventory.AddItem(new Item(q02Reward), 3);
        popUpWindow.AddToQueue($"Quest Complete! You have gotten {q02RewardAmt} {q02Reward.itemName}");
    }
    
    public void CraftAnItem()
    {
        popUpWindow.AddToQueue($"Quest Complete! You have gotten {q03RewardAmt} {q03Reward.itemName}");
    }

    public void Update()
    {
        BottleCheck();
        if(bottleComplete)
        {
            BottleQuest();
        }
    }

    public void BottleCheck()
    {
        //Check inventory to see if item amount is greater than zero
        amount = inventory.ContainsAmount(bottleItem.GetItem());
        if (amount >= 5)
        {
            bottleComplete = true;
        }
    }
}
