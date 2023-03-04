using UnityEngine;

[CreateAssetMenu(fileName = "ObstacleData", menuName = "ScriptableObjects/ObstacleData")]
public class ObstacleData : ScriptableObject
{
    public string obstacleName;
    public int obstacleID;
    public float speed;
    public bool canJump;
    public int removeLife;
    public float _currentTime;
    public float impactTime = 0.1f;

}
