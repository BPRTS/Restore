using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Refined Object", menuName = "Inventory System/Items/Refined")]
public class RefinedObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Refined;
    }
}
