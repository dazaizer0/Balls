using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallGenerationSettings : MonoBehaviour
{
    public static BallGenerationSettings instance;
    public float max_ball_range = 64;
    public float min_ball_range = 10;
    public int balls_amount = 20;

    private void Awake()
    {
        if (instance == null) { instance = this; }
    }
}
