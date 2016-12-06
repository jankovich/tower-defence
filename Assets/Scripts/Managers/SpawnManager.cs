using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoSingletone<SpawnManager>
{
    public List<Transform> spawnPoints = new List<Transform>();
    public List<GameObject> spawnedPrefabs = new List<GameObject>();

    public void SpawnPrefab(int spawnedPrefabId, int spawnPointId)
    {
        Instantiate(spawnedPrefabs[spawnedPrefabId], spawnPoints[spawnPointId].position, spawnPoints[spawnPointId].rotation);
    }
}
