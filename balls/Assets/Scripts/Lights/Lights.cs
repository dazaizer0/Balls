using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{

    public GameObject Car;
    public GameObject Light;
    public float speed = 2f;
    public Vector3 destination;

    void Start() 
    {

        Car = GameObject.Find("Car");
        destination = Car.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance(transform.position, Car.transform.position) < 20f)
        {

            Light.SetActive(true);
        }
        else
        {

            Light.SetActive(false);
        }
    }
}
