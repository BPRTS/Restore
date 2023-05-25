using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemObject item;
    public InventoryObject inventory;
    public bool nearPlayer;

    [SerializeField] private GameObject floatingText;

    private void Update()
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

    public void itemPickup()
    {

        var item = GetComponent<Item>();

        if (item && item.nearPlayer)
        {
            inventory.AddItem(item.item, 1);
            Destroy(item.gameObject);
            Destroy(floatingText);
        }
    }
}
