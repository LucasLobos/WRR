using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    [Header("Buttons")]
    [SerializeField] private Button restartButton;
    [SerializeField] private Button backToMenu;
    
    [Header("GameManager")]
    public GameManager gameManager;
    
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