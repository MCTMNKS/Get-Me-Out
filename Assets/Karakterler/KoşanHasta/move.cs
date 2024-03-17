using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class move : MonoBehaviour
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
        
        
            

            
            R2D.AddForce(new Vector3(movementValue.x * movementSpeed, 0f, movementValue.y * movementSpeed), ForceMode.Impulse);
        
        
    }
}
