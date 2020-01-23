using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] Attacker attackerPrefab;

    private bool shouldSpawn = true;
    private float minSpawnDelay = 1f;
    private float maxSpawnDelay = 3f;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (shouldSpawn)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttaacker();
        }
    }

    private void SpawnAttaacker()
    {
        Instantiate(attackerPrefab, transform.position, transform.rotation);
    }
}
