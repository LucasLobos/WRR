
using UnityEngine;

public enum ColorState
{
    Blue,
    Red,
    Green
}

public class PointArea : MonoBehaviour
{
    [SerializeField] private int pointsMateBlue = 10;
    [SerializeField] private int pointsMateRed = 20;
    [SerializeField] private int pointsMateGreen = 30;
    [SerializeField] private ColorState colorMate;
    private GameManager _gameManager;
    [SerializeField] private AudioClip collect2;

    private void Awake()
    {
        _gameManager = GameManager.instance;
    }

   


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SoundManager.instance.PlaySound(collect2);
            AddPoints();
        }
    }
    
    private void AddPoints()
    {
        switch (colorMate)
        {
            case ColorState.Green:
                _gameManager.UpdatePoints(pointsMateGreen);
                break;

            case ColorState.Red:
                _gameManager.UpdatePoints(pointsMateRed);
                break;

            case ColorState.Blue:
                _gameManager.UpdatePoints(pointsMateBlue);
                break;
        }
        
        Destroy(gameObject, 0.2f);
    
    }
    
}