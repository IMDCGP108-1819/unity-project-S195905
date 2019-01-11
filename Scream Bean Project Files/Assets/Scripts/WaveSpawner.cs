using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform beanPrefab1;
    public Transform beanPrefab2;
    public Transform beanPrefab3;
    public Transform beanPrefab4;
    public Transform beanPrefab5;
    public Transform beanPrefab6;
    public float timeBetweenWaves = 0f;
    private float countdown = 3f;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

    //An improved version of the earlier Spawner script. This one accomodates multiple prefabs, the number of beans increases per round and it allows for more prescise tuning of spawn locations

    private int waveNumber = 1;


    void Update()
    {
        if (countdown <= 0f)
        {
            SpawnWave();
            countdown = timeBetweenWaves;

        }

        countdown -= Time.deltaTime;

      
    }


    void SpawnWave()
    {

        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();

            {

            }
        }

        waveNumber++;

    }

    void SpawnEnemy()
    {
        Vector2 pos = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        if (GameObject.FindGameObjectsWithTag("Bean").Length < waveNumber)
        {
            Instantiate(beanPrefab1, pos, transform.rotation);
            if (waveNumber > 3)
            {
                Instantiate(beanPrefab2, pos, transform.rotation);

            }
            if (waveNumber > 6)
            {
                Instantiate(beanPrefab3, pos, transform.rotation);
            }
            if (waveNumber > 10)
            {
                Instantiate(beanPrefab4, pos, transform.rotation);
            }
            if (waveNumber > 13)
            {
                Instantiate(beanPrefab5, pos, transform.rotation);
            }
            if (waveNumber > 20)
            {
                Instantiate(beanPrefab6, pos, transform.rotation);
            }
            
        }

    }

      
        
}









