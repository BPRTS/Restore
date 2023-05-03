using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaterBottleText : MonoBehaviour
{
    public TextMeshProUGUI waterBottleText;
    int wbCount;

    private void OnEnable()
    {
        WaterBottle.OnWaterBottleCollected += IncrementWaterBottleCount;
    }
    private void OnDisable()
    {
        WaterBottle.OnWaterBottleCollected -= IncrementWaterBottleCount;
    }
    public void IncrementWaterBottleCount()
    {
        wbCount++;
        Debug.Log(wbCount);
        waterBottleText.text = $"Water Bottles: {wbCount}";
    }
}
