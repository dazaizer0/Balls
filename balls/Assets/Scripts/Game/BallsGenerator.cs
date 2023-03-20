using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class BallsGenerator : MonoBehaviour // Marcel odpalaes gre z poprawkami? twoj kod nie dziala ;-/  : wracamy do starego
{

    public GameObject ballToSpawn;
    public int numerOfBallsOnOneChunk;

    void Update()
    {

        Vector3 spawnPosition = new Vector3(Random.Range(transform.position.x + 256, transform.position.x - 256), Random.Range(transform.position.y + 256, transform.position.y - 256), Random.Range(transform.position.z + 256, transform.position.z - 256));

        for (int i = 0; i < numerOfBallsOnOneChunk; i ++)
        {

            Instantiate(ballToSpawn, spawnPosition, Quaternion.identity);
        }
    }

/*  public GameObject ballToSpawn;
    public int numerOfBallsOnOneChunk;
    public float player_radius; // to dodac 0.5(promien kulki do zespawnienia) = minimalna odleglosc zespawnianej kulki
    public float max_spawn_distance;


    void Start()
    {
        
    }

    void Update()
    {

        Vector3 spawnPosition = transform.position + ((new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f))).normalized * Random.Range(player_radius + 0.5f, max_spawn_distance));

        for (int i = 0; i < numerOfBallsOnOneChunk; i ++)
        {

            Instantiate(ballToSpawn, spawnPosition, Quaternion.identity);
        }
    }*/ 
}