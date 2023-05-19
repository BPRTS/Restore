using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Basic,
    Refined,
    Default
}

public abstract class ItemObject : ScriptableObject
{
    public GameObject iconPrefab;
    public ItemType type;
    [TextArea(15, 20)]
    public string description;
}
