using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    private PlayerMove playerMove;
    private Vector2 movement;
    private Rigidbody2D rb;

    private void Awake()
    {
        playerMove = new PlayerMove();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        playerMove.Enable();
    }

    private void Update()
    {
        PlayerInput();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void PlayerInput()
    {
        movement = playerMove.Movement.Move.ReadValue<Vector2>();
    }

    private void Move()
    {
        rb.MovePosition(rb.position + movement *(moveSpeed * Time.fixedDeltaTime));
    }
}
