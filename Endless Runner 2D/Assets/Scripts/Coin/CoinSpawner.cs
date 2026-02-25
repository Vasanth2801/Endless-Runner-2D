using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;
    [SerializeField] private float spawnInterval = 2f;
    private float timer;
    [SerializeField] private ObjectPooler pooler;

    void Start()
    {
        timer = spawnInterval;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SpawnCoin();
            timer = spawnInterval;
        }
    }

    void SpawnCoin()
    {
        float RandomX = Random.Range(minX, maxX);
        float RandomY = Random.Range(minY, maxY);
        pooler.SpawnFromPools("Coin", transform.position + new Vector3(RandomX, RandomY, 0), Quaternion.identity);
    }
}
