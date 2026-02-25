using UnityEngine;

public class CameraScroller : MonoBehaviour
{
    [SerializeField] private float cameraSpeed;

    private void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}