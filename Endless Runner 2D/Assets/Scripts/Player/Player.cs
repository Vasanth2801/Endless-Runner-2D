using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;

    [Header("References")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject gameOverPanel;

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}