using UnityEngine;
using UnityEngine.UIElements;

public class Arrow : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    bool isFacingRight = true;
    public float horizontalInput;
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
        FlipSprite();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
    void FlipSprite()
    {
        if (isFacingRight && horizontalInput > 0f || !isFacingRight && horizontalInput < 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }

}
