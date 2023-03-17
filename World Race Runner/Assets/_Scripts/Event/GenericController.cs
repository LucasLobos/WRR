using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenericController : MonoBehaviour
{
    public event Action OnMoveInput;
    public event Action OnJump;
    public event Action OnCheckGround;
    public event Action OnSlide;

    public GenericModel m_model;

    private void Awake()
    {
        m_model.GetControllerRef(this);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Slide();
        }

        CheckGround();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        Movement();
    }

    void Jump()
    {
        OnJump?.Invoke();
    }

    void Movement()
    {
        OnMoveInput?.Invoke();
    }

    void CheckGround()
    {
        OnCheckGround?.Invoke();
    }

    void Slide()
    {
        OnSlide?.Invoke();
    }
}