using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenericController : MonoBehaviour
{
    public event Action OnMoveInput;
    public event Action OnJump;
    //public event Action OnSceneLoseGame;

    public GenericModel m_model;


    private void Awake()
    {
        m_model.GetControllerRef(this);
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        Jump();
        Movement();


    }

    void Jump() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnJump?.Invoke();
        }
    }

    void Movement()
    {
        OnMoveInput?.Invoke();
    }


    //void LoseGame()
    //{
    //OnSceneLoseGame?.Invoke();
    //if (currentHealth == 0)
    //{
    //    LoseGame();
    //}
    //}
}

