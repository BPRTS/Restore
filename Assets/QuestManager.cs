using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    public Toggle bottleQuest;
    public PopUpWindow popUpWindow;


    //TODO CALL THIS 
   public void BottleQuest()
    {
        bottleQuest.isOn = true;
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
