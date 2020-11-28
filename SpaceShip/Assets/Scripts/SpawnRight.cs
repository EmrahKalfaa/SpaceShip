using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRight : MonoBehaviour
{
    public GameObject[] Enemy;

    public GameObject SpawnPointRightToLeft;
    public GameObject SpawnPointRightToRight;

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

        if (timer > 1.0f)
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

        if (randomSpawnNumber == 0)
        {
            return SpawnPointRightToLeft;
        }

        else
        {
            return SpawnPointRightToRight;
        }
    }

}
