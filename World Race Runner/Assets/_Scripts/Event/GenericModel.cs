using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class GenericModel : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private Rigidbody m_rigidbody;
    [SerializeField] private Collider m_collider;
    
    [Header("Jump")]
    [SerializeField] private float m_jumpForce;
    [SerializeField] private bool grounded = true;
    [SerializeField] private LayerMask mask;
    private bool _isJumping;
    
    [Header("Slide")]
    [SerializeField]private float _slideTime;
    private float _initialGravity;
    private bool _canSlide = true;

    [Header("Movement")]
    private  float leftLanePosition = -4.4f; // Posición del carril izquierdo en el eje X
    private  float middleLanePosition = -1.8f; // Posición del carril medio en el eje X
    private  float rightLanePosition = 0.9f; // Posición del carril derecho en el eje X
    private float currentXPosition; // Posición actual del personaje en el eje X
    
    
    public void GetControllerRef(GenericController p_controller)
    {
        p_controller.OnMoveInput += OnMoveHandler;
        p_controller.OnJump += OnJumpHandler;
        p_controller.OnCheckGround += OnCheckGroundHandler;
        p_controller.OnSlide += OnSlideHanlder;
    
    }

    private void Start()
    {
        m_collider = GetComponent<Collider>();
        _animator = GetComponent<Animator>();
        currentXPosition = middleLanePosition;
        transform.position = new Vector3(currentXPosition, transform.position.y, transform.position.z);
    }

    
    //-------------------------MOVEMENT----------------------------------
    public void OnMoveHandler()
    {
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

    //-------------------------JUMP----------------------------------
    public void OnJumpHandler()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            _animator.SetBool("IsJumping",true);
            _isJumping = true;
            m_rigidbody.AddForce(Vector3.up * m_jumpForce, ForceMode.Impulse);
            Debug.Log("Recived OnJump, from GenericController, to GenericModel");
        }
    }
    private void OnCheckGroundHandler()
    {
        RaycastHit hitInfo = new RaycastHit();

        if (Physics.Raycast(transform.position, -Vector3.up, out hitInfo, 0.6f, mask))
        {
            grounded = true;
            _animator.SetBool("IsJumping",false);
            _isJumping = false;
        }
        else
        {
            grounded = false;
            
        }
    }
    //-------------------------SLIDE----------------------------------
    public IEnumerator Slide()
    {
        Vector3 originalSizeCollider = m_collider.transform.localScale;
        _animator.SetBool("IsSliding",true);
        _canSlide = false;
        Vector3 newCollider = new Vector3(transform.localScale.x, transform.localScale.y * 0.8f, transform.localScale.z);
        m_collider.transform.localScale = newCollider;
        
        yield return new WaitForSeconds(_slideTime);
        _canSlide = true;
        _animator.SetBool("IsSliding",false);
        
        m_collider.transform.localScale = originalSizeCollider;

    }
    public void OnSlideHanlder()
    {
        if (Input.GetKeyDown(KeyCode.S) && _canSlide)
        {
            StartCoroutine(Slide());

        }
    }
}