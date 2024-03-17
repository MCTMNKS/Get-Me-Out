using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public Rigidbody R2D;
    public Vector2 movementValue;
    public float movementSpeed = 3f;


    private void Awake()
    {
        R2D = GetComponent<Rigidbody>();
    }

    public void moving(InputAction.CallbackContext value)
    {
        if (value.performed)
        {
            movementValue = value.ReadValue<Vector2>();
        }
        if (value.canceled)
        {
            movementValue = value.ReadValue<Vector2>();
        }
    }
}
