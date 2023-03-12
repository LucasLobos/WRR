using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenericModel : MonoBehaviour
{
    private Animator _animator;
    private Camera playerCamera;
    
    [Header("Jump")]
    [SerializeField] private float m_jumpForce;
    [SerializeField] private Rigidbody m_rigibody;
    [SerializeField] private bool grounded = true;
    [SerializeField] private LayerMask mask;
    private bool _isJumping;
    
    
    [Header("Slide")]
    [SerializeField]private float _slideTime;
    private float _initialGravity;
    private bool _canSlide = true;
    [SerializeField] private TrailRenderer _trailRenderer;
    
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
        _animator = GetComponent<Animator>();
        playerCamera = GetComponentInChildren<Camera>();
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
            m_rigibody.AddForce(Vector3.up * m_jumpForce, ForceMode.Impulse);
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
        _animator.SetTrigger("IsSliding");
        _trailRenderer.emitting = true;
        _canSlide = false;
        /*playerCamera.transform.position = new Vector3(-0.04300332f, 1.178f, -3.61f); */   //(-0.128844023, 1.07433367, -3.85811424);
        yield return new WaitForSeconds(_slideTime);

        /*
        playerCamera.transform.position = new Vector3(-0.04300332f, 2.66f, -7.195f);
        */
        _canSlide = true;
        _trailRenderer.emitting = false;
    }
    public void OnSlideHanlder()
    {
        if (Input.GetKeyDown(KeyCode.S) && _canSlide)
        {
            StartCoroutine(Slide());
        }
    }
}