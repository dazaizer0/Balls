using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsGenerator : MonoBehaviour
{

    public GameObject ballToSpawn;
    public int numerOfBallsOnOneChunk;


    void Start()
    {
        
    }

    void Update()
    {

        Vector3 spawnPosition = new Vector3(Random.Range(transform.position.x + 128, transform.position.x - 128), Random.Range(transform.position.y + 128, transform.position.y - 128), Random.Range(transform.position.z + 128, transform.position.z - 128));

        for (int i = 0; i < numerOfBallsOnOneChunk; i ++)
        {

            Instantiate(ballToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}