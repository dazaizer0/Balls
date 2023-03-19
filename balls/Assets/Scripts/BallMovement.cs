using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    Rigidbody rb;

    [Header("speed: from 9 to 10000")]
    public float speed;
    private Vector3 direction;

    
    private void Start()
    {

        rb = GetComponent<Rigidbody>();

        speed = Random.Range(1, speed);
        rb.velocity = (new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f).normalized) * speed;
    }
}
