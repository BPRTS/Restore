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

    [Header("Repair Oxygen")]
    public ItemObject q02Reward;
    public int q02RewardAmt;

    [Header("Craft an Item")]
    public ItemObject q03Reward;
    public int q03RewardAmt;

    //TODO CALL THIS 
    public void BottleQuest()
    {
        bottleQuest.isOn = true;
        
        inventory.AddItem(new Item(q01Reward), 1);
        popUpWindow.AddToQueue($"Quest Complete! You have gotten {q01RewardAmt} {q01Reward.itemName}");


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
}
