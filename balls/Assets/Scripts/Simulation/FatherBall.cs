using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherBall : MonoBehaviour
{

    public Transform Mother;
    public float speed;

    void Update()
    {

        speed = speed + 1 * Time.deltaTime;
        
        Vector3 pos = Vector3.MoveTowards(transform.position, Mother.position, speed * Time.deltaTime);
        GetComponent<Rigidbody>().MovePosition(pos);
    }
}
