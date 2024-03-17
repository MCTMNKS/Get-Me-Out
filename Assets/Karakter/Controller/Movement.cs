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
            //    Debug.Log(message: "Performed");
            movementValue = value.ReadValue<Vector2>();
            //    Debug.Log(movementValue.x + " " + movementValue.y);
            //    R2D.AddForce(new Vector3(movementValue.x * movementSpeed, 0f, movementValue.y * movementSpeed), ForceMode.Impulse);
        }
        if (value.canceled)
        {
            movementValue = value.ReadValue<Vector2>();
        }
    }
}
