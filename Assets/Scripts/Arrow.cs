using UnityEngine;
public class Arrow : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    public float horizontalInput;
    private float direction = -1f;
    PlayerAttack playerAttack;

    void Start()
    {
        playerAttack = FindAnyObjectByType<PlayerAttack>();
    }
    void Update()
    {
        transform.position += Vector3.right * direction * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }

    public void SetDirection(bool isFacingRight)
    {
        direction = !isFacingRight ? 1f : -1f;
        Vector3 scale = transform.localScale;
        scale.x = !isFacingRight ? Mathf.Abs(scale.x) : -Mathf.Abs(scale.x);
        transform.localScale = scale;
    }
}