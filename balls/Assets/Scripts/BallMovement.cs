using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    Rigidbody rb;
    public float speed; // speed = Range(1, 9) or Range(1, 10000)
    private Vector3 direction;

    
    private void Start()
    {

        rb = GetComponent<Rigidbody>();

        speed = Random.Range(1, speed);
        rb.velocity = (new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f).normalized) * speed;
    }
}
