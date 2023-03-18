using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{

    [SerializeField] private Button startButton;
    [SerializeField] private Button tutorialButton;
    [SerializeField] private Button quitButton;

    public GameManager gameManager;


    private void Awake()
    {
        gameManager = GameManager.instance;
    }

    
    
    private void Start()
    {
        startButton.onClick.AddListener(gameManager.RestartGame);
        tutorialButton.onClick.AddListener(gameManager.TutorialGame);
        quitButton.onClick.AddListener(gameManager.QuitGame);

    }
}
