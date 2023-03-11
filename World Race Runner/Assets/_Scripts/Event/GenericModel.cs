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


    private readonly float leftLanePosition = -4; // Posición del carril izquierdo en el eje X
    private readonly float middleLanePosition = -2; // Posición del carril medio en el eje X
    private readonly float rightLanePosition = 1; // Posición del carril derecho en el eje X
    private float currentXPosition; // Posición actual del personaje en el eje X

    public void GetControllerRef(GenericController p_controller)
    {
        p_controller.OnMoveInput += OnMoveHandler;
        p_controller.OnJump += OnJumpHandler;
    }

    private void Start()
    {
        currentXPosition = middleLanePosition;
        transform.position = new Vector3(currentXPosition, transform.position.y, transform.position.z);
    }

    public void OnMoveHandler()
    {
        /*
        var input = Input.GetAxis("Horizontal");
        */

        if (Input.GetKeyDown(KeyCode.A) && currentXPosition != leftLanePosition)
        {
            if (currentXPosition == middleLanePosition)
            {
                currentXPosition = leftLanePosition;
            }
            else if (currentXPosition == rightLanePosition)
            {
                currentXPosition = middleLanePosition;
            }

            transform.position = new Vector3(currentXPosition, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.D) && currentXPosition != rightLanePosition)
        {
            if (currentXPosition == middleLanePosition)
            {
                currentXPosition = rightLanePosition;
            }
            else if (currentXPosition == leftLanePosition)
            {
                currentXPosition = middleLanePosition;
            }

            transform.position = new Vector3(currentXPosition, transform.position.y, transform.position.z);
        }

        Debug.Log("Recived OnMoveInput, from GenericController, to GenericModel");
    }


    public void OnJumpHandler()
    {
        m_rigibody.AddForce(Vector3.up * m_jumpForce, ForceMode.Impulse);
        Debug.Log("Recived OnJump, from GenericController, to GenericModel");
    }


   
}