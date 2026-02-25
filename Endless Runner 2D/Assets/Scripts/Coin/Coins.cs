using UnityEngine;

public class Coins : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Coin Collected!");
            gameObject.SetActive(false);
        }
    }
}