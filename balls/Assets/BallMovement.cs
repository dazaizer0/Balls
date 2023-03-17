using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float speed; // = 5f;
    private Vector3 direction;

    
    private void Start()
    {
        speed = Random.Range(3, 6);
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f).normalized;
    }

    private void Update()
    {

        transform.position += direction * speed * Time.deltaTime;
    }
}
