using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement_v1 : MonoBehaviour
{
    Rigidbody rb;
    public float jump_delta_v;
    public float accel;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        rb.AddForce(((Input.GetKey(KeyCode.W) ? 1 : 0) - (Input.GetKey(KeyCode.S) ? 1 : 0)) * accel * transform.forward, ForceMode.Acceleration);
        rb.AddForce(((Input.GetKey(KeyCode.D) ? 1 : 0) - (Input.GetKey(KeyCode.A) ? 1 : 0)) * accel * transform.right , ForceMode.Acceleration);
        rb.AddForce(((Input.GetKey(KeyCode.Space) ? 1 : 0) - (Input.GetKey(KeyCode.LeftShift) ? 1 : 0)) * jump_delta_v * transform.up , ForceMode.Acceleration);
    }
}
