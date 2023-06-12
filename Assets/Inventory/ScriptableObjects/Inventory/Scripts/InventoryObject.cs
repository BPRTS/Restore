using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEditor;
using System.Runtime.Serialization;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject
{

    public string savePath;
    public ItemDatabaseObject database;
    public Inventory Container;

    //Check if item already exists in inventory (if so, add to stack).
    //If item does not exist in inventory, create new inventory slot for item.
    public void AddItem(Item _item, int _amount)
    {
        for (int i = 0; i < Container.Items.Count; i++)
        {
            if (Container.Items[i].item.Id == _item.Id)
            {
                Container.Items[i].AddAmount(_amount);
                return;
            }
        }
        Container.Items.Add(new InventorySlot(_item.Id, _item, _amount));
    }
 
    #region Save Functionality
    [ContextMenu("Save")]
    public void Save()
    {
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream(string.Concat(Application.persistentDataPath, savePath), FileMode.Create, FileAccess.Write);
        formatter.Serialize(stream, Container);
        stream.Close();
    }
    [ContextMenu("Load")]
    public void Load()
    {
        if (File.Exists(string.Concat(Application.persistentDataPath, savePath)))
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(string.Concat(Application.persistentDataPath, savePath), FileMode.Open, FileAccess.Read);
            Container = (Inventory)formatter.Deserialize(stream);
            stream.Close();
        }
    }
    [ContextMenu("Clear")]
    public void Clear()
    {
        Container = new Inventory();
    }
    #endregion

    //Check if inventory contains item.
    //When calling this, right now it needs to pull from InventorySlot instead of ItemObject
    public bool Contains(Item item, int amount)
    {
        for (int i = 0; i < Container.Items.Count; i++)
        {
            if (Container.Items[i].GetItem().Id == item.Id && Container.Items[i].GetAmount() >= amount)
                return true;
        }
        return false;
    }
    //Check inventory and return amount
    //When calling this, right now it needs to pull from InventorySlot instead of ItemObject

    public int ContainsAmount(Item item)
    {
        for (int i = 0; i < Container.Items.Count; i++)
        {
            if (Container.Items[i].GetItem().Id == item.Id)
                return Container.Items[i].GetAmount();
        }
        return 0;
    }

    public bool RemoveCraftItems(Item item, int amount)
    {
        for (int i = 0; i < Container.Items.Count; i++)
        {
            if (Container.Items[i].GetItem().Id == item.Id && Container.Items[i].GetAmount() >= amount)
                Container.Items[i].RemoveAmount(amount);

        }
        return false;
    }

}

[System.Serializable]
public class Inventory
{
    public List<InventorySlot> Items = new List<InventorySlot>();

}

[System.Serializable]
public class InventorySlot
{
    public int ID;
    public Item item;
    public int amount;
    public Item GetItem() { return item; }
    public int GetAmount() { return amount; }

    public InventorySlot(int _id, Item _item, int _amount)
    {
        ID = _id;
        item = _item;
        amount = _amount;


    }
    public void AddAmount(int value)
    {
        amount += value;

    }
    public void RemoveAmount(int value)
    {
        amount -= value;
    }
}