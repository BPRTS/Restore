using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    public Toggle bottleQuest;
    public PopUpWindow popUpWindow;
    public InventoryObject inventory;
    
    public ItemObject item;


    //TODO CALL THIS 
    public void BottleQuest()
    {
        bottleQuest.isOn = true;
        
        inventory.AddItem(new Item(item), 1);
        popUpWindow.AddToQueue("Quest Complete! You have gotten 1 Nylon Twine!");
        //TODO ADD ITEM PLEASEEEEEE

    }
   public void RepairOxygen()
    {

    }
    
    public void CraftAnItem()
    {

    }
}
