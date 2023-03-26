using UnityEngine;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{

    [SerializeField] private Button Level1;
    [SerializeField] private Button Level2;
    [SerializeField] private Button Level3;
    [SerializeField] private Button Back;

    public GameManager gameManager;


    private void Awake()
    {
        gameManager = GameManager.instance;
    }

    
    
    private void Start()
    {
        Level1.onClick.AddListener(gameManager.LevelFarm);
        Level2.onClick.AddListener(gameManager.LevelCity);
        Level3.onClick.AddListener(gameManager.LevelSpace);
        Back.onClick.AddListener(gameManager.BackToMenu);

    }
}