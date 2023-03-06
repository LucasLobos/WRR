using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenericModel : MonoBehaviour
{ 
    [SerializeField] private float m_speed;
    [SerializeField] private float m_jumpForce;
    [SerializeField] private Rigidbody m_rigibody;

    public void GetControllerRef(GenericController p_controller)
    {
        p_controller.OnMoveInput += OnMoveHandler;
        p_controller.OnJump += OnJumpHandler;
        //p_controller.OnSceneLoseGame += OnSceneLoseGame;
    }

    public void OnMoveHandler()
    {
        var l_horizontal = Input.GetAxisRaw("Horizontal");
        transform.position += transform.right * (l_horizontal * m_speed * Time.deltaTime);

        Debug.Log("Recived OnMoveInput, from GenericController, to GenericModel");
    } 

    public void OnJumpHandler()
    {
        m_rigibody.AddForce(Vector3.up * m_jumpForce, ForceMode.Impulse);
        Debug.Log("Recived OnJump, from GenericController, to GenericModel");
    }

    //public void OnSceneLoseGame()
    //{
    //    SceneManager.LoadScene("Lose");
    //    Debug.Log("Recived OnSceneLoseGame, from GenericController, to GenericModel");
    //}
}

