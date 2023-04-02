using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class TutorialVolume : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private AudioMixer audioMixer;
    
    public GameManager gameManager;

    private void Awake()
    {
        gameManager = GameManager.instance;
    }

    
    
    private void Start()
    {
        backButton.onClick.AddListener(gameManager.BackToMenu);
        
    }

    public void ChangeVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }
}
