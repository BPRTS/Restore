using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FindInvAmount : MonoBehaviour
{
    public InventoryObject inventory;
    public InventorySlot item;

    //Script attached to crafting, quests, etc:
    //any area where x amount is required to complete an action
    public void Update()
    {
        var amount = inventory.ContainsAmount(item.GetItem());
        transform.Find("Amount").GetComponent<TextMeshProUGUI>().text = amount.ToString("n0");
    }

}
