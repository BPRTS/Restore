using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenBehaviour : MonoBehaviour
{
    public Slider oxygenBar;
    public Player_Movement playerScript;
    public Transform player;

    // Update is called once per frame
    void Update()
    {

     //   if(Vector3.Distance(this.transform.position,player.position)<60f)
       // {
     //       Debug.Log("yes");
       //     playerScript.isBreathing= true;
       // }
       // else
       // {
        //    Debug.Log(Vector3.Distance(this.transform.position, player.position));
        //    playerScript.isBreathing= false;
      //  }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if(other.name == "Player")
        {
            playerScript.isBreathing = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
        if(other.name == "Player")
        {
            playerScript.isBreathing = false;
        }
    }
}