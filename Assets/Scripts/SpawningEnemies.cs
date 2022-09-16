using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningEnemies : MonoBehaviour
{
    public GameObject EnemyPrefab;
    private int spawnRangeX;
    private int spawnRangeY;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies" , 1 , 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemies()
    {
        Vector3 spawnPosition = new  Vector3(-7.19f , 0.199f , 4.79f);

        Instantiate(EnemyPrefab , spawnPosition , EnemyPrefab.transform.rotation);
    }
}
