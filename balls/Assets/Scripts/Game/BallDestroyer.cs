using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Internal;

public class BallDestroyer : MonoBehaviour
{

    public GameObject cam;
    public bool parent = false;


    void Start()
    {
        cam = GameObject.Find("PlayerCamera");
    }

    void Update()
    {

        if (Vector3.Distance(transform.position, cam.transform.position) > BallGenerationSettings.instance.max_ball_range) 
        {
            if(parent) {Debug.Log("Parent Alive");}
            else { Destroy(gameObject); BallGenerationSettings.instance.balls_amount += 1; }
        }
    }
}
