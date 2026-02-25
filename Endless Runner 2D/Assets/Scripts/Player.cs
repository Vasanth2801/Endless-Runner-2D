using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;

    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Input Settings")]
    [SerializeField] private float moveInput;

    private void Update()
    {
        moveInput = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, moveInput * moveSpeed);
    }
}