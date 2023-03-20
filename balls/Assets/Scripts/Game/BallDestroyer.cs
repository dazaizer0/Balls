using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyer : MonoBehaviour
{

    public GameObject cam;
    public bool parent = false;

    void Start()
    {
        
        cam = GameObject.Find("Camera");

    }

    void Update()
    {
        if (Vector2.Distance(transform.position, cam.transform.position) > 64)
        {

            if(parent) {Debug.Log("Parent Alive");}
            else {Destroy(gameObject, 3f);}
        }
    }
}
