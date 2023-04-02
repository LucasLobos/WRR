using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    [Header("Score")] [SerializeField] private TMP_Text scoreGame;
    public void ShowScore(int totalPoints)
    {
        scoreGame.text = "SCORE : " +  totalPoints;
    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene("Start");
    }
}

