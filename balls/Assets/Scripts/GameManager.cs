using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI FPS;
    public float fps, update_delay_s = 0.7f;


    private void Start()
    {
        StartCoroutine(FpsCounter());
    }
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape))
        {

            SceneManager.LoadScene(0);
            // QuitProgram();
        }
        // w dokumentacji unity startowali coroutine-y tylko w Start(), wiec zrobi�em to samo plus while w IEnumerator-rze
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

    public void to_simulation()
    {

        Debug.Log("to_simulation");
        SceneManager.LoadScene(1);
    }
    public void to_game()
    {

        Debug.Log("to_game");
        SceneManager.LoadScene(2);
    }

    IEnumerator FpsCounter()
    {
        while (true)
        {
            fps_to_string();
            yield return new WaitForSeconds(2);
        }
    }
}
