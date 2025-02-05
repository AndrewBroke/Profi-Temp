using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject enemyPrefab;
    public float spawnTime = 5;

    IEnumerator Timer()
    {
        while (true)
        {
            // ∆дать spawnTime секунд
            yield return new WaitForSeconds(spawnTime);

            Instantiate(enemyPrefab, spawnPoint.transform.position, Quaternion.identity);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Timer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
