using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    
    
    [Header("Score")]
    [SerializeField] private TMP_Text scoreGame;
    
    [Header("Buttons")]
    [SerializeField] private Button restartButton;
    [SerializeField] private Button backToMenu;
    
    [Header("GameManager")]
    public GameManager gameManager;

    
    public void ShowScore(int totalPoints)
    {
        scoreGame.text = "SCORE : " + totalPoints;
    }

    private void Awake()
    {
        gameManager = GameManager.instance;
    }

    private void Start()
    {
        restartButton.onClick.AddListener(gameManager.RestartGame);
        backToMenu.onClick.AddListener(gameManager.BackToMenu);
    }
    
    
}