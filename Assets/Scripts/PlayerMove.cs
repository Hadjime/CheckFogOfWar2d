using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public InputAction actionMove;

    private Vector3 direction;
    private float speed = 2f;
    private void Start()
    {
        actionMove.performed += HandlerMove;
    }

    private void HandlerMove(InputAction.CallbackContext context)
    {
        direction = new Vector3(context.ReadValue<Vector2>().x, context.ReadValue<Vector2>().y, 0); 
    }

    private void OnEnable()
    {
        actionMove.Enable();
    }
    private void OnDisable()
    {
        actionMove.Disable();
    }

    private void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);
    }
}
