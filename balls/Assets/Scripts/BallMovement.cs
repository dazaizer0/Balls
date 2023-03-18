using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    Rigidbody rb;
    public float speed;
    private Vector3 direction;

    
    private void Start()
    {

        rb = GetComponent<Rigidbody>();

        speed = Random.Range(1, speed);  // or 9
        // direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f).normalized;
        rb.velocity = (new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f).normalized) * speed;
    }

    private void Update()
    {

        // transform.position += direction * speed * Time.deltaTime;
    }
}
