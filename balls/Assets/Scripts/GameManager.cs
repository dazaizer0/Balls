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

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape))
        {

            QuitProgram();
        }

        StartCoroutine(FpsCounter());
        fps = (int)(1f / Time.unscaledDeltaTime);
    }

    public void QuitProgram()
    {

        Application.Quit();
        Debug.Log("Quit");
    }

    public void fps_to_string()
    {

        FPS.text = fps + ".fps";
    }

    IEnumerator FpsCounter()
    {
        
        fps_to_string();
        yield return new WaitForSeconds(2);
    }
}
