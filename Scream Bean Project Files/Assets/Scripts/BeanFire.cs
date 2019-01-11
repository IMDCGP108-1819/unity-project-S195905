using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanFire : MonoBehaviour
{
    public GameObject beanPrefab;
    public Vector2 spawnValues;
    public int BeanCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    // Use this for initialization
    void Start()
    {
        //Spawns Beans in waves at a random location between 4 integers, 2 X and 2 Y ints.
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < BeanCount; i++)
            {
                Vector3 spawnPosition = new Vector2(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(beanPrefab, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds (waveWait);
        }

    }

}