using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WaterBottle : MonoBehaviour, ICollectible
{
    public static event Action OnWaterBottleCollected;
    public void Collect()
    {
        Debug.Log("You collected a Water Bottle.");
        Destroy(gameObject);
        OnWaterBottleCollected?.Invoke();
    }
}
