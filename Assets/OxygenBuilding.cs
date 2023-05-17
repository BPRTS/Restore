using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class OxygenBuilding : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject oxygenBubble;
    public Transform player;

    public int materialCost;
    public int timeToBuild = 10;

    private Vector3 bubblechange = new Vector3(0.1f, 0.1f, 0.1f);
    public float targetSize = 78f;
    // public Item[] itemsNeeded;

    public bool rebuilt;


    private bool isCoroutineExecuting = false;

  

    void Start()
    {
        this.transform.GetChild(1).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (rebuilt)
        {
            this.transform.GetChild(0).gameObject.SetActive(false);
        }
        else if(!rebuilt)
        {
            this.transform.GetChild(1).gameObject.SetActive(true);
        }
        if(Vector3.Distance(player.position,transform.position)<12f && !rebuilt)
        {
            if(Input.GetMouseButtonDown(0))
            {
                StartCoroutine(Build(timeToBuild));
                
            }
        }
    }


    IEnumerator Build(int time)
    {
        if (isCoroutineExecuting)
            yield break;

        isCoroutineExecuting = true;
        Debug.Log("Building...");

        yield return new WaitForSeconds(3);

        // Code to execute after the delay
        rebuilt = true;
        oxygenBubble.SetActive(true);

        StartCoroutine(Expand());
        

        isCoroutineExecuting = false;
    }
    IEnumerator Expand()
    {
        while (oxygenBubble.transform.localScale.z < targetSize && oxygenBubble.transform.localScale.x < targetSize && oxygenBubble.transform.localScale.y < targetSize)
        {
            oxygenBubble.transform.localScale += bubblechange;
            yield return new WaitForSeconds(0.008f);
        }
        
    }
}
