using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour
{
    public float movementSpeed;

    CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        UpdateMovement();
    }

    void UpdateMovement()
    {
        var x = Input.GetAxis("Horizontal");

        var input = new Vector3();
        input += transform.right * x;

        characterController.Move(input * movementSpeed * Time.deltaTime);

    }
}
