using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFollow : MonoBehaviour
{
    public GameObject player;
    public float targetDistance;
    public float allowedDistance = 5;
    public GameObject gameNPC;
    public float followSpeed;
    public RaycastHit shot; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
        {
            targetDistance = shot.distance;
            if(targetDistance >= allowedDistance)
            {
                followSpeed = 0.2f;
                //gameNPC.GetComponent<Animation>().Play("animation name walking");
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, followSpeed);
            }
            else
            {
                followSpeed = 0f;
                //gameNPC.GetComponent<Animation>().Play("animation name idle");
            }
        }
    }
}
