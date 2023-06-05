using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairBehavior : MonoBehaviour
{
    [SerializeField] private GameObject floatingText;
    public bool nearPlayer;
    public OxygenBuilding oxygenBuilding;
    public PopUpWindow popUpWindow;

    public InventoryObject inventory;
    public CraftClass craftClass;

    void Update()
    {
        var floatText = transform.Find("FloatingText");
        if (nearPlayer)
        {
            floatingText.SetActive(true);
        }
        else
        {
            floatingText.SetActive(false);
        }
    }

    public void RepairBuilding()
    {
        if(craftClass.CanCraft(inventory))
        {
            StartCoroutine(oxygenBuilding.Build());
        }
        else
        {
            popUpWindow.AddToQueue("You don't have enough materials!");
        }
        
        //if items are in
        //
        //else
        //
        
    }
}
