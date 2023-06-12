using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorialSequence : MonoBehaviour
{
    public Canvas maincanvas;
    public InventoryObject inventory;
    public InventorySlot bottleItem;
    public GameObject invisibleWalls;
    public InventorySlot nylonItem;

    private List<string> text = new List<string>()
    { 
        "0", //Movement
        "1", //Pick Up
        "2", //Open Inventory
        "3", //Craft
        "4" //Tutorial End
    };
    public TMP_Text textbox;
    public int stage = 0;
    private List<bool> stageflags = new List<bool>()
    {
        false, false, false, false, false
    };

    // Start is called before the first frame update
    void Start()
    {
       // maincanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(stage == 1 && inventory.ContainsAmount(bottleItem.GetItem()) >=1)
        {
            stage = 2;
        }

        if(stage == 3 && inventory.ContainsAmount(nylonItem.GetItem()) >= 1)
        {
            stage = 4;
        }


        //Move
        if (stage == 0 && !stageflags[0])
        {
            stageflags[0] = true;
            textbox.text = text[0];
            maincanvas.transform.GetChild(0).gameObject.SetActive(true);
        }
        //pick up item
        else if (stage == 1 && !stageflags[1])
        {
            stageflags[1] = true;
            textbox.text = text[1];
        }
        //open inventory
        else if (stage == 2 && !stageflags[2])
        {
            invisibleWalls.SetActive(false);
            stageflags[2] = true;
            textbox.text = text[2];
            maincanvas.transform.GetChild(1).gameObject.SetActive(true);
        }
        //craft
        else if (stage == 3 && !stageflags[3])
        {
            stageflags[3] = true;
            textbox.text = text[3];
        }
        //End
        else if (stage == 4 && !stageflags[4])
        {
            
            stageflags[4] = true;
            textbox.text = text[4];
            StartCoroutine(closeTutorial());
        }
        /*else if (stage <=4)
        {
            Debug.Log(stage);
        }*/
    }

    private IEnumerator closeTutorial()
    {
        yield return new WaitForSeconds(5);
        transform.gameObject.SetActive(false);
    }
}


