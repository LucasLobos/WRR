using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour
{
    [SerializeField] private float timeElapsed = 0;

    void Update()
    {

        timeElapsed += Time.deltaTime;
        Debug.Log($"Playing time = {timeElapsed}{("f1")}");
    }
    
    
    
    
    
    
    
    
}
