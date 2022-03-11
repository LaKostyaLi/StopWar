using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //спаун без использования корутины
    public GameObject _spawnObj;
    public float time;
    float lastSpawnedTime;


    void Update()
    {
        if(Time.time>lastSpawnedTime+time)
        { 
          SpawnPref();
          lastSpawnedTime = Time.time;
        }
    }

    public void SpawnPref()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-14, 20), 30, Random.Range(-11, 11));

        Instantiate(_spawnObj, randomSpawnPosition, Quaternion.identity);
    }
   

}
