using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Score_Code : MonoBehaviour
{
    private Text score;
    protected static int total_points;

    void Start()
    {
        total_points = 0;
        score = GetComponent<Text>();
        score.text = "COINS: " + total_points;
    }

    private void Update()
    {
        score.text = "COINS: " + total_points;
    }

    public static void AddPointToScore()
    {
        total_points++;
    }
}