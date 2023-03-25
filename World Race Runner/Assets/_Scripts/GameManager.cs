using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool dontDestroyOnLoad;

    [Header("Final points")] public int totalPoints = 0;

    //[Header("Game Time")] public float elapsedTime = 0.0f;
    //public float lastTime = 0.0f;
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

    //public float GetTime()
    //{
    //    return elapsedTime;
    //}
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

  

    //Gestion Musica y efectos de sonido
}