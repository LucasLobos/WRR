using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{

    [SerializeField] private Button startButton;


    private void Awake()
    {
        startButton.onClick.AddListener(LoadGame);
    }
    
    
    public void LoadGame()
    {
        SceneManager.LoadScene("World");
    }
}
