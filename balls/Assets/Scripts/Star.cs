using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(other);
    }
}