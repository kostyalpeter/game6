using UnityEngine;
public class Shoot : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    public float horizontalInput1;
    public float horizontalInput2;
    private float direction = -1f;
    Reverse reverse;
    public void Start()
    {
        reverse = GetComponent<Reverse>();
    }
    public void Update()
    {
        if (Reverse.reverse == false)
        {
            transform.position += Vector3.right * direction * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0f, 0, 0f);
        }
        if (Reverse.reverse == true)
        {
            transform.position += Vector3.left * direction * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0f, 0, 180f);
        }
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
            collision.gameObject.GetComponent<PlayerHealth1>().ShotDamage();
        }
        if (collision.gameObject.GetComponent<PlayerHealth2>())
        {
            collision.gameObject.GetComponent<PlayerHealth2>().ShotDamage();
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