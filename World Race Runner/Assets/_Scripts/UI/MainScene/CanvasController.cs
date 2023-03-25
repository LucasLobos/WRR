using TMPro;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    [Header("Score")] [SerializeField] private TMP_Text scoreGame;
    
    
    public void ShowScore(int points)
    {
        scoreGame.text = "SCORE : " +  points;
    }

  
}

