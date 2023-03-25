using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    [Header("Buttons")]
    [SerializeField] private Button backToMenu;
    [SerializeField] private CanvasController canvasController;

    [Header("GameManager")]
    private GameManager gameManager;
    
    private void Awake()
    {
        gameManager = GameManager.instance;
    }

    private void Start()
    {

        backToMenu.onClick.AddListener(gameManager.BackToMenu);
        SetPoint();
       
    }
     

    private void SetPoint()
    {
        canvasController.ShowScore(gameManager.GetPoints());
    }


    
}