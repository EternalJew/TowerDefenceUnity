using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] private Transform enemyPrefab;
    [SerializeField] private Transform spawnPoint;
    public float timeBetweenWaves = 5f;
    private float countDown = 2f;
    private int waveIndex = 1;
    void Update()
    {
        if(countDown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countDown = timeBetweenWaves;
        }

        countDown -= Time.deltaTime;
    }
    IEnumerator SpawnWave()
    {
        waveIndex++;

        for(int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
