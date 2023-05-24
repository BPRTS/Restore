using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemObject item;
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
}
