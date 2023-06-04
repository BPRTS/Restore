using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairBehavior : MonoBehaviour
{
    [SerializeField] private GameObject floatingText;
    public bool nearPlayer;

    void Update()
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

    public void RepairBuilding()
    {
/*        var building = GetComponent<RepairBehavior>();
        
        if (building && building.nearPlayer)
        {
            building.nearPlayer = false;
            Destroy(building.gameObject);
            Destroy(floatingText);
        }*/


    }
}
