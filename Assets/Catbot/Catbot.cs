using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Catbot : MonoBehaviour
{
    // Start is called before the first frame update

    private NavMeshAgent catBot;
    public Transform playerTarget;
    void Start()
    {
        catBot = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        catBot.SetDestination(playerTarget.position);
    }
}
