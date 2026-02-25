using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0f;
        Debug.Log("Game Over!");
    }
}
