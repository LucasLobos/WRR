using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    [SerializeField] private PlayerStats player;

    [Header("Time")] [SerializeField] private TMP_Text timeGame;
    /*
    private float _elapsedTime = 0.0f;
    */

    [Header("Score")]
    [SerializeField] private TMP_Text scoreGame;

    [Header("Player Life")] [SerializeField]
    private Image healhMeter1;

    [SerializeField] private Sprite healtyHeart1,
        deadHeart1;
    
    private void Awake()
    {
        var player = this.player.GetComponent<PlayerStats>();
        player.currentHealth = player.maxHealth;
    }

    public void ShowScore(int totalPoints)
    {
        scoreGame.text = "SCORE : " + totalPoints;
    }
    
    private void Update()
    {
        UpdateLife(player.currentHealth);
        /*_elapsedTime += Time.deltaTime;
        ShowTime();*/
    }

    public void ShowTime(float time)
    {
        timeGame.text = "TIME : " + time.ToString("0.0");
    }
    
    private void UpdateLife(int currentLife)
    {
        var isHealthy1 = player.currentHealth >= player.maxHealth;
        healhMeter1.sprite = isHealthy1 ? healtyHeart1 : deadHeart1;
    }
}
