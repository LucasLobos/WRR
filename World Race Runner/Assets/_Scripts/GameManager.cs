using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool dontDestroyOnLoad;
    private static int _totalPoints = 0;
    
    private float _elapsedTime = 0.0f;
    private float _lastTime = 0.0f;
    
    
    [SerializeField] private CanvasController canvasController;
    [SerializeField] private CanvasWinScene canvasControllerWinScene;
    [SerializeField] private GameOver canvasControllerGameOverScene;

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
    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        ControlTime(_elapsedTime);
    }

    public void ControlTime(float time)
    {
        _lastTime = time;
        canvasController.ShowTime(_lastTime);
    }
    //------------------ Points
    public void UpdatePoints(int points)
    {
        _totalPoints += points;
        canvasController.ShowScore(_totalPoints);
        /*canvasControllerWinScene.ShowScore(_totalPoints);
        canvasControllerGameOverScene.ShowScore(_totalPoints);*/

    }
    
    //------------------------Scene swaps
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

    public void NextLevelSnow()
    {
        
    }
    
    
  
    
    
    //Gestion Musica y efectos de sonido
}