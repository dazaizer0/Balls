using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI FPS;
    public float fps;

    void Start()
    {
        
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape))
        {

            QuitProgram();
        }

        StartCoroutine(FpsCounter());
        FPS.text = fps + ".fps";
    }

    public void QuitProgram()
    {

        Application.Quit();
        Debug.Log("Quit");
    }

    public void FPScounter()
    {

        fps = (int)(1f / Time.unscaledDeltaTime);
    }

    IEnumerator FpsCounter()
    {
        
        FPScounter();
        yield return new WaitForSeconds(2);
    }
}
