using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuntimeMovement : MonoBehaviour
{
    private Movement movementController;
    private CharacterController characterController;
    [SerializeField] float fraction;
    Animator animator;

    private void Start()
    {
        movementController = GetComponent<Movement>();
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        characterController.Move(new Vector3((movementController.movementValue.x * movementController.movementSpeed) / fraction, 0f, (movementController.movementValue.y * movementController.movementSpeed) / fraction));
        animator.SetFloat("speed", Mathf.Abs(characterController.velocity.x) + Mathf.Abs(characterController.velocity.z));
    }
}
