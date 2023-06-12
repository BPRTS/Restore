using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundItemTutorial : MonoBehaviour
{
    public ItemObject item;
    public InventoryObject inventory;
    public bool nearPlayer;
    public TutorialSequence tutorialSequence;

    [SerializeField] private GameObject floatingText;

    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "Game")
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


    public void itemPickup()
    {
        if(tutorialSequence.stage == 1)
        {
            tutorialSequence.stage = 2;
        }

        var item = GetComponent<GroundItem>();

        if (item && item.nearPlayer)
        {
            inventory.AddItem(new Item(item.item), 1);
            item.nearPlayer = false;
            Destroy(item.gameObject);
            Destroy(floatingText);
        }
    }
}
