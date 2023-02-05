
using System;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed;

    private void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var direction = new Vector3(horizontal, 0, 0);
        
        MoveHorizontal(direction);

    }


    private void MoveHorizontal(Vector3 moveHorizontal)
    {
        transform.position += moveHorizontal * (speed * Time.deltaTime);
    }
}
