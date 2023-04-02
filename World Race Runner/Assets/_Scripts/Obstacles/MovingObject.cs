using UnityEngine;

public class MovingObject : EntityObstacle
{
    public Transform pointA;
    public Transform pointB;
    
    private float startTime;
    private float journeyLength;
    private bool isMovingToB;
    [SerializeField] private float speedPoints;

    void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(pointA.position, pointB.position);
        isMovingToB = true;
    }

    void Update()
    {
        MoveForward();
        float distCovered = (Time.time - startTime) * speedPoints;
        float fracJourney = distCovered / journeyLength;

        if (isMovingToB)
        {
            transform.position = Vector3.Lerp(pointA.position, pointB.position, fracJourney);
        }
        else
        {
            transform.position = Vector3.Lerp(pointB.position, pointA.position, fracJourney);
        }

        if (fracJourney >= 1.0f)
        {
            isMovingToB = !isMovingToB;
            startTime = Time.time;
        }
        
    }
    
    
    
    
}


