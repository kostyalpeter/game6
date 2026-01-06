using UnityEngine;
public class Arrow : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    public float horizontalInput1;
    public float horizontalInput2;
    private float direction = -1f;
    PlayerAttack1 playerAttack1;
    PlayerAttack2 playerAttack2;
    PlayerType player;
    void Start()
    {
        playerAttack1 = FindAnyObjectByType<PlayerAttack1>();
        playerAttack2 = FindAnyObjectByType<PlayerAttack2>();
        player = GetComponent<PlayerType>();
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
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.GetComponent<PlayerHealth1>())
        {
            collision.gameObject.GetComponent<PlayerHealth1>().TakeDamage();
        }
        if (collision.gameObject.GetComponent<PlayerHealth2>())
        {
            collision.gameObject.GetComponent<PlayerHealth2>().TakeDamage();
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