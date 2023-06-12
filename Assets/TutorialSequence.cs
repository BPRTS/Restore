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
        "Let's get going! Use the joystick at the bottom of the screen to move.", //Movement
        "There is a lot of plastic here, but we can use it! Tap on it to pick it up.", //Pick Up
        "Great! Now that you have some items, let's open your inventory.", //Open Inventory
        "Items you pick up in the world can be combined to make new ones! Open the Crafting menu.", //Craft
        "Time to get cleaning up around here. We'll need more resources if we want to expand." //Tutorial End
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
        }
        /*else if (stage <=4)
        {
            Debug.Log(stage);
        }*/
    }
}


