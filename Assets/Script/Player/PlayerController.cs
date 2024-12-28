using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;
public class PlayerController : MonoBehaviour
{
    public Vector2 inputDirection;
    public float moveSpeed;
    private Rigidbody m_rb;
    public void Start()
    {
        m_rb = GetComponent<Rigidbody>();
    }
    public void FixedUpdate()
    {
        m_rb.velocity = new Vector3(inputDirection.x*moveSpeed,0,inputDirection.y*moveSpeed);
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        inputDirection = context.ReadValue<Vector2>();
    }
}
