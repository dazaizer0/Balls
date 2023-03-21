using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class BallsGenerator : MonoBehaviour
{

    public GameObject ball_to_spawn;
    Vector3 spawn_position;

    void Update()
    {

        if (BallGenerationSettings.instance.balls_amount < 0) return;

        spawn_position = transform.position + ((new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f))).normalized * Random.Range(BallGenerationSettings.instance.min_ball_range, BallGenerationSettings.instance.max_ball_range));
        Instantiate(ball_to_spawn, spawn_position, Quaternion.identity);
        BallGenerationSettings.instance.balls_amount -= 1;
    } 
}