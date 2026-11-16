using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    
    public GameObject[] PopcornPrefabs;
    private float spawnLimitXLeft = 8;
    private float spawnLimitXRight = -17;
    private float spawnPosY = 30;
   
    private float spawnLimitZLeft = 12;
    private float spawnLimitZRight = -10;
    private float startDelay = 3.0f;
    private float spawnInterval = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPopcorn", startDelay, spawnInterval );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomPopcorn()
    {
        int PopcornIndex = Random.Range(0, PopcornPrefabs.Length);
         Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY,Random.Range(spawnLimitZLeft, spawnLimitZRight));
        // instantiate ball at random spawn location
        Instantiate(PopcornPrefabs[PopcornIndex], spawnPos, PopcornPrefabs[PopcornIndex].transform.rotation);

    }
}
