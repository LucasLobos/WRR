using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    [Header("Buttons")]
    [SerializeField] private Button restartButton;
    [SerializeField] private Button backToMenu;
    [SerializeField] private CanvasController canvasController;

    [Header("GameManager")]
    private GameManager gameManager;
    
    private void Awake()
    {
        gameManager = GameManager.instance;
    }

    private void Start()
    {
        restartButton.onClick.AddListener(gameManager.RestartGame);
        backToMenu.onClick.AddListener(gameManager.BackToMenu);
        SetPoint();
        SetTime();
    }
     

    private void SetPoint()
    {
        canvasController.ShowScore(gameManager.GetPoint());
    }

    private void SetTime()
    {
        canvasController.ShowTime(gameManager.GetTime());
    }
}