using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool dontDestroyOnLoad;

    [Header("Final points")] public int totalPoints = 0;

    //[Header("Game Time")] public float elapsedTime = 0.0f;
    //public float lastTime = 0.0f;
    
    [SerializeField] private CanvasController canvasController;

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

    //private void Update()
    //{
    //    elapsedTime += Time.deltaTime;
    //    ControlTime(elapsedTime);
    //}


    //public void ControlTime(float time)
    //{
    //    lastTime = time;
    //    canvasController.ShowTime(lastTime);
    //}

    //------------------ Points
    public void UpdatePoints(int points)
    {
        totalPoints += points;
        canvasController.ShowScore(totalPoints);
        
    }

    public int GetPoints()
    {
        return totalPoints;
    }

    //public float GetTime()
    //{
    //    return elapsedTime;
    //}

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

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    //Gestion Musica y efectos de sonido
}