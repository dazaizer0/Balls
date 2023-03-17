using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    public Transform Me;
    public GameObject Ball;
    bool segz = false;


    void OnTriggerEnter(Collider other)
    {

        if(segz == false)
        {

            Vector3 spawnPlace = new Vector3(Random.Range(Me.position.x + 1, Me.position.x - 1), Random.Range(Me.position.y + 1, Me.position.y - 1), Random.Range(Me.position.z + 1, Me.position.z - 1));
            Instantiate(Ball, spawnPlace, Quaternion.identity);
            segz = true;
        }else
        {
            
            print("rozmnarzanie zakonczone");
        }

        //StartCoroutine(SpawnBall());
    }

    public IEnumerator SpawnBall()
    {

        Vector3 spawnPlace = new Vector3(Random.Range(Me.position.x + 1, Me.position.x - 1), Random.Range(Me.position.y + 1, Me.position.y - 1), Random.Range(Me.position.z + 1, Me.position.z - 1));
        Instantiate(Ball, spawnPlace, Quaternion.identity);

        yield return new WaitForSeconds(4f);
    }
}
