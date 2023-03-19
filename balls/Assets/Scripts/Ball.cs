using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool isParent = false;

    [Header("Compotents")]
    public GameManager gm;
    public MeshRenderer mr;

    [Header("Objects")]
    public Transform ThisBall;
    public GameObject BallToSpawn;

    [Header("Stats")]
    bool multiplied = false;
    public float LifeTime;
    public int fertility;

    [Header("Stats")]
    public string Kind;
    int KindOfBall;

    // big and chunky
    public float age = 1;


    void Start()
    {

        LifeTime = Random.Range(15, 25);

        if(!isParent)
        {

            KindOfBall = Random.Range(1, 4);
        }else if(isParent)
        {
            KindOfBall = 0;
        }

        if(KindOfBall == 0)
        {

            Kind = "parent";
            mr.material.color = Color.blue;
        }else if(KindOfBall == 1)
        {

            Kind = "white";
            mr.material.color = Color.white;
        }else if(KindOfBall == 2)
        {

            Kind = "green";
            mr.material.color = Color.green;
        }else if(KindOfBall == 3)
        {

            mr.material.color = Color.yellow;
            Kind = "yellow";
        }

    }

    void Update()
    {

        /*age += 1 * Time.deltaTime / 30;

        Vector3 scale = new Vector3(age, age, age);
        transform.localScale = scale;*/

        if(isParent)
        {

            mr.material.color = Color.blue;
            LifeTime = 7;
        }else
        {

            LifeTime -= 1 * Time.deltaTime;
            Destroy(gameObject, LifeTime);
        }
    }

    void OnTriggerEnter(Collider other)
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
                
                //gm.bals += 1;
                //gm.actbals += 1;
            }

            multiplied = true;
        }else
        {
            
            Debug.Log("Parent: multiplication ended");
        }
    }

     void OnTriggerExit(Collider other)
     {

        if(Kind == "white")
        {

            mr.material.color = Color.white;
        }else if(Kind == "green")
        {

            mr.material.color = Color.green;
        }else if(Kind == "yellow")
        {

            mr.material.color = Color.yellow;
        }else if(Kind == "yellow")
        {

            mr.material.color = Color.blue;
        }
     }
} // zadnych dup chlopcze