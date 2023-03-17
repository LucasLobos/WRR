using System;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Button restartButton;
    [SerializeField] private Button backToMenu;
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