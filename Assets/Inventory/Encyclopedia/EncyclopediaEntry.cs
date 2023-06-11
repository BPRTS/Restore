using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EncyclopediaEntry : MonoBehaviour
{
    // setting the item, the inventory (for database reference)
    public ItemObject item;
    public ItemDatabaseObject db;
    public GameObject infoPanel;
    [SerializeField] private GameObject infoPrefab;
    public Transform infoParent;
    GameObject obj;
    GameObject makeParent;

    //FMOD Trigger
    public string fmodOpenEncyclopediaEvent = ("event:/MenuSound/Confirm");
    public string fmodCloseEncyclopediaEvent = ("event:/MenuSound/Cancel");

    public void ListEntry()
    {

        // set background image as true and create an instance of the Item Info prefab
        /*infoPanel.SetActive(true);*/


        DestroyParents("ParentInfo");
        MakeParent();
        obj = Instantiate(infoPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        
        /*GameObject obj = Instantiate(infoPrefab, new Vector3(0, 0, 0), Quaternion.identity);*/
        obj.transform.SetParent(makeParent.transform);
        /*obj.transform.SetParent(infoParent, false);*/
        obj.GetComponent<RectTransform>().localPosition = new Vector3(-5, -2, 0);

        // Pull information from scriptable item set as a variable
        obj.transform.Find("Icon").GetComponent<Image>().sprite = db.GetItem[item.Id].uiDisplay;
        obj.transform.Find("ItemName").GetComponent<TextMeshProUGUI>().text = db.GetItem[item.Id].itemName;
        obj.transform.Find("Class").GetComponent<TextMeshProUGUI>().text = db.GetItem[item.Id].type.ToString();
        obj.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = db.GetItem[item.Id].description;
        obj.transform.Find("Search").GetComponent<TextMeshProUGUI>().text = db.GetItem[item.Id].searchSuggestion;

    }


    public void MakeParent ()
    {
        if (!makeParent)
        {
            makeParent = new GameObject($"Parent {item}");
            makeParent.tag = "ParentInfo";
            makeParent.transform.SetParent(infoParent.transform);
            makeParent.AddComponent<RectTransform>();
            makeParent.GetComponent<RectTransform>().localPosition = new Vector3(-251, -279, 0);

            FMODUnity.RuntimeManager.PlayOneShot(fmodOpenEncyclopediaEvent);
        }
    }

    void DestroyParents(string tag)
    {
        GameObject[] parents = GameObject.FindGameObjectsWithTag(tag);
        for (int i = 0; i < parents.Length; i++)
        {
            Destroy(parents[i]);
            
            FMODUnity.RuntimeManager.PlayOneShot(fmodCloseEncyclopediaEvent);
        }
    }
}
