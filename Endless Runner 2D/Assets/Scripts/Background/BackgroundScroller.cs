using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] private float backgroundSpeed;
    [SerializeField] private SpriteRenderer sprite;

    private void Update()
    {
        sprite.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0);
    }
}
