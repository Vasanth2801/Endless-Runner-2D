using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            Debug.Log("Game Over!");
        }
        gameObject.SetActive(false);
    }
}