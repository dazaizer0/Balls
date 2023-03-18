using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool isParent = false;

    [Header("Compotents")]
    public MeshRenderer mr;

    [Header("Objects")]
    public Transform ThisBall;
    public GameObject BallToSpawn;

    [Header("Stats")]
    bool multiplied = false;
    private float LifeTime;
    public int fertility;


    void Start()
    {
        LifeTime = Random.Range(25, 35);
    }

    void Update()
    {

        if(isParent)
        {

            LifeTime = 7;
        }else
        {

            LifeTime -= 1 * Time.deltaTime;
            Destroy(gameObject, LifeTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(!isParent)
        {

            if(multiplied == false)
            {

                mr.material.color = Color.red;
                Vector3 spawnPlace = new Vector3(Random.Range(ThisBall.position.x + 1, ThisBall.position.x - 1), Random.Range(ThisBall.position.y + 1, ThisBall.position.y - 1), Random.Range(ThisBall.position.z + 1, ThisBall.position.z - 1));
            
                fertility = Random.Range(1, 2);
                int i = 0;
                while (i != fertility)
                {

                    Instantiate(BallToSpawn, spawnPlace, Quaternion.identity);
                    i++;
                }

                multiplied = true;
            }else
            {
            
                print("multiplication ended");
            }
        }else
        {

            if(multiplied == false)
            {

                mr.material.color = Color.red;
                Vector3 spawnPlace = new Vector3(Random.Range(ThisBall.position.x + 1, ThisBall.position.x - 1), Random.Range(ThisBall.position.y + 1, ThisBall.position.y - 1), Random.Range(ThisBall.position.z + 1, ThisBall.position.z - 1));
            
                fertility = Random.Range(2, 3);
                int i = 0;
                while (i != fertility)
                {

                    Instantiate(BallToSpawn, spawnPlace, Quaternion.identity);
                    i++;
                }

                multiplied = true;
            }else
            {
            
                print("multiplication ended");
            }
        }
    }

     void OnTriggerExit(Collider other)
     {

        if(isParent)
        {
            
            mr.material.color = Color.blue;
        }else
        {

            mr.material.color = Color.green;
        }
     }
}
