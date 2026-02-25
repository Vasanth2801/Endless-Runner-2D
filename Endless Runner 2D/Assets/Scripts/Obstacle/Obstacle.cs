using UnityEngine;

public class Obstacle : MonoBehaviour
{
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        AudioManager.Instance.PlayExplosion();
        gameObject.SetActive(false);
    }
}