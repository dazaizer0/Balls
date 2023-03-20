using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyer : MonoBehaviour
{

    public GameObject cam;
    public bool parent = false;
    public float max_survival_distance; // 128

    void Start()
    {
        
        cam = GameObject.Find("Camera");
    }

    void Update()
    {//       tu \|/ bylo "Vector2" (do usuniecia, to tylko notka) : ODP ---------> // tu masz racvje moj blad, powinen byc v3 dodanie floata tez dobry wybor

        if (Vector3.Distance(transform.position, cam.transform.position) > max_survival_distance) 
        {

            if(parent) {Debug.Log("Parent Alive");}
            else {Destroy(gameObject, 3f);}
        }
    }
}
