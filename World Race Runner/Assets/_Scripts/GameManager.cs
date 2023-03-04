using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool dontDestroyOnLoad;
    [SerializeField] private float timeElapsed = 0;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            if (dontDestroyOnLoad)
            {
                DontDestroyOnLoad(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    void Update()
    {
        GameTime();
    }
    
    public void GameTime()
    {
        timeElapsed += Time.deltaTime;
        /*Debug.Log("Time Game " + timeElapsed);*/
    }
    
    
    



}