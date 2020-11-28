using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLeft : MonoBehaviour
{
    public float minusSecond = 0.0f;

    public GameObject[] Enemy;

    public GameObject SpawnPointLeftToLeft;
    public GameObject SpawnPointLeftToRight;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        //SKORA BAGLI OLARAK ENEMY SPAWN HIZI BELIRLENECEK
        timer += Time.deltaTime;

        if(timer > 1.0f - minusSecond)
        {
            SpawnEnemy();
            timer = 0;
        }
        
        
    }

    public void SpawnEnemy()
    {
        GameObject EnemySpawn;

        EnemySpawn = Instantiate(Enemy[RandomEnemyIndex()], RandomSpawnPosition().transform.position, RandomSpawnPosition().transform.rotation);

    }

    private int RandomEnemyIndex()
    {
        if (Enemy.Length <= 1)
        {
            return 0;
        }

        int randomIndex = Random.Range(0, Enemy.Length);

        return randomIndex;
    }


    private GameObject RandomSpawnPosition()
    {
        int randomSpawnNumber = Random.Range(0, 2);

        if(randomSpawnNumber == 0)
        {
            return SpawnPointLeftToLeft;
        }

        else
        {
            return SpawnPointLeftToRight;
        }
    }

    public void MinusSecond()
    {
        if(minusSecond < 0.5)
        {
            minusSecond += 0.05f;
        }
    }
}
