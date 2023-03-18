using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {

            QuitProgram();
        }
    }

    public void QuitProgram()
    {

        Application.Quit();
        Debug.Log("Quit");
    }
}
