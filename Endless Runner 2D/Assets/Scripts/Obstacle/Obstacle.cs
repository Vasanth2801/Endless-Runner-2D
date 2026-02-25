using UnityEngine;

public class Obstacle : MonoBehaviour
{
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        gameObject.SetActive(false);
    }
}