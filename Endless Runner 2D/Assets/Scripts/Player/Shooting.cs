using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] private Transform firePoint;
    [SerializeField] private float bulletForce = 20f;

    [Header("References")]
    [SerializeField] private ObjectPooler pooler;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        AudioManager.Instance.PlayShoot();
        GameObject bullet = pooler.SpawnFromPools("Bullet", firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
    }
}