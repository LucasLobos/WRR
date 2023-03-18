using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool dontDestroyOnLoad;
    [SerializeField] private TMP_Text scoreGame;
    private static int _totalPoints = 0;
    
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            if (dontDestroyOnLoad)
            {
                DontDestroyOnLoad(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void UpdatePoints(int points)
    {
        _totalPoints += points;
        scoreGame.text = "SCORE : " + _totalPoints;
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene("Start");
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene("World");
    }

    public void TutorialGame()
    {
        SceneManager.LoadScene("Tutorial");
    }
    
    
    
    //Puntuacion del jugador
    
  
    
    
    //Gestion Musica y efectos de sonido
}