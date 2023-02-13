using UnityEngine;

public enum ColorState
{
    Normal,
    Red,
    Green
}

public class PointArea : MonoBehaviour
{
    [SerializeField] private ColorState currentColor;

    private int _points = 0;
    private int _totalPoints = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            /*GameManager manager = GameManager.instance;
            manager.AddPoints();*/
            AddPoints();
            Destroy(gameObject, 0.2f);
        }
    }

    private void AddPoints()
    {
        switch (currentColor)
        {
            case ColorState.Green:
                _points += 3;
                break;

            case ColorState.Red:
                _points += 2;
                break;

            case ColorState.Normal:
                _points += 1;
                break;
        }

        Debug.Log($"Contando puntos {_points}");
    }
}