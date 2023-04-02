using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool dontDestroyOnLoad;

    [Header("Final points")] public int totalPoints;
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
   
    
    public void TutorialGame()
    {
        SceneManager.LoadScene("Tuto&VolumeControl");
    }
    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }
    
    public void LevelFarm()
    {
        SceneManager.LoadScene("Word 1");
    }
    public void LevelCity()
    {
        SceneManager.LoadScene("World 2");
    }
    public void LevelSnow()
    {
        SceneManager.LoadScene("World 3");
    }

}