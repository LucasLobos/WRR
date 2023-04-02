using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{

    [Header("Buttons")]
    [SerializeField] private Button menuButton;
    [SerializeField] private CanvasController canvasController;

    [Header("GameManager")]
    [SerializeField] private GameManager gameManager;
    
    private void Awake()
    {
        gameManager = GameManager.instance;
    }

    private void Start()
    {
        BackToMenu();
        SetPoint();
       
    }
    
    private void BackToMenu()
    {
        menuButton.onClick.AddListener(canvasController.BackToMenu);

    }
    private void SetPoint()
    {
        canvasController.ShowScore(gameManager.GetPoints());
    }

  
}