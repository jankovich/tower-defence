using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoSingletone<SpawnManager>
{
    public List<Wave> waves = new List<Wave>();
    public List<Transform> spawnPoints = new List<Transform>();
 

    IEnumerator SpawnWave(Wave spawnedWave)
    {
        for(int i = 0; i < spawnedWave.wave.Count; i++)
        {
            for(int j = 0; j < spawnedWave.wave[i].amount; j++)
            {
                SpawnEnemy(spawnedWave.wave[i].enemyType, spawnedWave.wave[i].spawnPointId);
                yield return new WaitForSeconds(spawnedWave.wave[i].timeToNextSpawn);
            }
            yield return new WaitForSeconds(spawnedWave.timeToNextPartOfWave);
        }       
    }

    public void SpawnEnemy(Enemy enemyPrefab, int spawnPointId)
    {
        Instantiate(enemyPrefab, spawnPoints[spawnPointId].position, spawnPoints[spawnPointId].rotation);
    }


    //test
    void Start()
    {
        StartCoroutine(SpawnWave(waves[0])); 
    }
}
