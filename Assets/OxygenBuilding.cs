using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OxygenBuilding : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject oxygenBubble;
    public Transform player;

    public int materialCost;
    public int timeToBuild = 5;
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
            Debug.Log("real");
            if(Input.GetMouseButtonDown(0))
            {
                StartCoroutine(Build(timeToBuild));
                
            }
        }
    }


    IEnumerator Build(float time)
    {
        if (isCoroutineExecuting)
            yield break;

        isCoroutineExecuting = true;
        Debug.Log("Building...");

        yield return new WaitForSeconds(time);

        // Code to execute after the delay
        rebuilt = true;
        oxygenBubble.SetActive(true);

        isCoroutineExecuting = false;
    }
}
