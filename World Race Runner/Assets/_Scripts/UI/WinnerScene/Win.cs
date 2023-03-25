using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{

    [Header("Buttons")]
    [SerializeField] private Button menuButton;
    [SerializeField] private CanvasController canvasController;

    [Header("GameManager")]
    private GameManager gameManager;
    
    private void Awake()
    {
        gameManager = GameManager.instance;
    }

    private void Start()
    {
        menuButton.onClick.AddListener(gameManager.BackToMenu);
        SetPoint();
       
    }
     

    private void SetPoint()
    {
        canvasController.ShowScore(gameManager.GetPoints());
    }

    //private void SetTime()
    //{
    //    canvasController.ShowTime(gameManager.GetTime());
    //}

  
}