using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform enemySpawnPoint;
    public float delay;
    public int enemyCount;
    public int i;

    // Update is called once per frame
    void Start()
    {
        //enemyPrefab.transform.position = enemySpawnPoint.transform.position;
        StartCoroutine(Spawn(delay, enemyCount, i));
    }

    public IEnumerator Spawn(float delay, int enemyCount, int i)
    {
        Instantiate(enemyPrefab, enemySpawnPoint.position, enemySpawnPoint.rotation);
        i++;
        yield return new WaitForSeconds(delay);
        if(i < enemyCount)
        {
            StartCoroutine(Spawn(delay, enemyCount, i));
        }
    }

    public void StartWave()
    {
        StartCoroutine(Spawn(delay, enemyCount, 0));
    }
}
