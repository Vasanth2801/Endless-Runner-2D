using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    private GameManager gm;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>7)
        {
            Destroy(gameObject);
        }
        rb.velocity = Vector2.left * (speed * gm.speedMultiplier);
    }
}
