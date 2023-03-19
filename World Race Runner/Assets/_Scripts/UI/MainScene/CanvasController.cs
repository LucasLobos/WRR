using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    [Header("Time")] [SerializeField] private TMP_Text timeGame;
    [Header("Score")] [SerializeField] private TMP_Text scoreGame;
    
    
    public void ShowScore(int points)
    {
        scoreGame.text = "SCORE : " +  points;
    }

    public void ShowTime(float time)
    {
        timeGame.text = "TIME : " + time.ToString("0.0");
    }
}