using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundItem : MonoBehaviour
{
    public ItemObject item;
    public InventoryObject inventory;
    public bool nearPlayer;

    [SerializeField] private GameObject floatingText;

    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name != "Title Screen")
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
    }


    public void itemPickup()
    {
        var item = GetComponent<GroundItem>();

        if (item && item.nearPlayer)
        {
            inventory.AddItem(new Item(item.item), 1);
            item.nearPlayer = false;
            Destroy(item.gameObject);
            Destroy(floatingText);
        }
    }
}
