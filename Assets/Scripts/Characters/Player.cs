using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    
    
    private Vector3 _moveDirection;
    private bool IsGrounded;
    private Rigidbody rb;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);
        InputManager.SetGameControls();

        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * _moveDirection;
        CheckGround();
    }

    public void SetMovementDirection(Vector3 currentDirection)
    {
        _moveDirection = currentDirection;
    }

    public void Jump()
    {
        Debug.Log("Jump called");
        if (IsGrounded)
        {
            Debug.Log("I Jumped");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }

    private void CheckGround()
    {
        IsGrounded = Physics.Raycast(transform.position, Vector3.down, GetComponent<Collider>().bounds.size.y);
        Debug.DrawRay(transform.position, Vector3.down * GetComponent<Collider>().bounds.size.y, Color.green, 0,
            depthTest: false);

    }
    



}
