using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{

    public float startValue = 0f;
    public float endValue = 10f;
    public float lerpTime = 2f;

    private float currentTime = 0f;

    void Update ()
    {

        currentTime += Time.deltaTime;
        float t = Mathf.Clamp01(currentTime / lerpTime);
        float currentValue = Mathf.Lerp(startValue, endValue, t);

        // transform.position = new Vector3(currentValue, 0f, 0f);
        transform.localScale = new Vector3(currentValue, currentValue, currentValue);
    }
}
