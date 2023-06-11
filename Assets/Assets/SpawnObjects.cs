using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnObjects : MonoBehaviour
{
    public GameObject rawMaterial;
    public Transform[] spawnPoints = new Transform[5];
    [SerializeField] private int spawnCount;

    public void objectSpawn()
    {
        GameObject instanceObject = GameObject.Instantiate(rawMaterial, spawnPoints[spawnCount].transform.position, spawnPoints[spawnCount].transform.rotation);
        Debug.Log(spawnPoints[spawnCount].name);

    }
    void Start()
    {
        spawnCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "Game")
        {

            if (spawnCount < spawnPoints.Length)
            {
                objectSpawn();
                spawnCount++;
            }
        }
    }
}
