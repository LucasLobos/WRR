
using UnityEngine;
using UnityEngine.UI;

public class EntryScene : MonoBehaviour
{

    [SerializeField] private Button startButton;
    [SerializeField] private Button optionButton;
    [SerializeField] private Button quitButton;

    public GameManager gameManager;


    private void Awake()
    {
        gameManager = GameManager.instance;
    }

    
    
    private void Start()
    {
        startButton.onClick.AddListener(gameManager.Levels);
        optionButton.onClick.AddListener(gameManager.TutorialGame);
        quitButton.onClick.AddListener(gameManager.QuitGame);

    }
}
