using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherBall : MonoBehaviour
{
    public Transform parent;
    public float speed;

    void Start()
    {

    }

    void Update()
    {
        while(transform.position != parent.position)
        {

            transform.position = Vector3.MoveTowards(transform.position, parent.transform.position, speed);
        }
    }
}
