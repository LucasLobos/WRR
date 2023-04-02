using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [Header("Button")]
    [SerializeField] private Button backToMenu;
    
    [Header("Canvas Controller")]
    [SerializeField] private CanvasController canvasController;
    
    [Header("Game Manager")]
    [SerializeField] private GameManager gameManager;
    
    private void Awake()
    {
        gameManager = GameManager.instance;
    }
    
    private void Start()
    {
        backToMenu.onClick.AddListener(canvasController.BackToMenu);
        SetPoint();
    }


    private void SetPoint()
    {
        
        canvasController.ShowScore(gameManager.GetPoints());
    }
    
}