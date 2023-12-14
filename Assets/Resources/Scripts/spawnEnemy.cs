using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTurret : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform enemySpawnPoint;
    public float delay;
    public int enemyCount;
    private int i;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(Spawn(delay));
    }

    IEnumerator Spawn(float delay)
    {
        Instantiate(enemyPrefab, enemySpawnPoint);
        i++;
        yield return new WaitForSeconds(delay);
        if(i <= enemyCount)
        {
            StartCoroutine(Spawn(delay));
        }
    }
}
