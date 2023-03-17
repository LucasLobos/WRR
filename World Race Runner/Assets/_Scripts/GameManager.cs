using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool dontDestroyOnLoad;

    
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
    
    public void TotalPoints(){
        
        
        
    }
    
    
    //Gestion Musica y efectos de sonido
}