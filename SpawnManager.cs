using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    private PlayerController playerController;

    private float zSpawn = 11.0f;
    private float zSpawnRange = 7.0f;
    private float ySpawn = 0f;
    private float flyingYSpawn = 3.5f;

    private float startDelay = 1.0f;
    private float spawnInterval = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomEnemy()
    {
        float randomZ = Random.Range(zSpawnRange, zSpawn);
        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 flyingSpawnPos = new Vector3(transform.position.x, flyingYSpawn, randomZ);
        Vector3 spawnPos = new Vector3(transform.position.x, ySpawn, randomZ);
        if(playerController.gameOver == false)
        {
            if (randomIndex == 1)
            {
                Instantiate(enemies[1], flyingSpawnPos, enemies[1].gameObject.transform.rotation);
            }
            else
            {
                Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
            }
        }

    }
}
