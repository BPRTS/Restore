using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvBehavior : MonoBehaviour
{

    public InventoryObject inventory;
    private ShaderVariantCollection floatText;



    public void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<GroundItem>();
        if (item)
        {
            item.nearPlayer = true;
            Debug.Log("An Item Is Near");
            Debug.Log($"nearPlayer is {item.nearPlayer}");
            /*inventory.AddItem(item.item, 1);
            Destroy(other.gameObject);*/
        }
    }
    public void OnTriggerExit(Collider other)
    {
        var item = other.GetComponent<GroundItem>();
        if (item)
        {
            item.nearPlayer = false;
            Debug.Log($"nearPlayer is {item.nearPlayer}");
            Debug.Log("An Item Is No Longer Near");

        }
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inventory.Save();
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            inventory.Load();
        }
    }

    private void OnApplicationQuit()
    {
        inventory.Container.Items.Clear();
    }
}
