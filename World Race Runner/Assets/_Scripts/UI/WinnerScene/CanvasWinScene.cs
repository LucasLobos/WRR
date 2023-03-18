
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasWinScene : MonoBehaviour
{
  
    [Header("Score")]
    [SerializeField] private TMP_Text scoreGame;
    
    
    [SerializeField] private Button menuButton;
    [SerializeField] private Button nextLevel;
    public GameManager gameManager;
    
    public void ShowScore(int _totalPoints)
    {
        scoreGame.text = "SCORE : " + _totalPoints;
    }
    
    private void Start()
    {
        menuButton.onClick.AddListener(gameManager.BackToMenu);
        nextLevel.onClick.AddListener(gameManager.NextLevelSnow);
    }
}
