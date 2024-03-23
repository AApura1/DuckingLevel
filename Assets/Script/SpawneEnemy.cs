using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawneEnemy : MonoBehaviour
{

    public GameObject toSpawn;
    public float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnem", spawnTimer, spawnTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnem()
    {
        Instantiate(toSpawn,transform.position,Quaternion.identity);
    }

}
