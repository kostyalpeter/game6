using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement2 : MonoBehaviour
{
    public float horizontalInput;
    public float jumpForce = 4f;
    public float moveSpeed = 5f;
    public bool isFacingRight = false;
    public bool isGrounded = false;
    Animator animator;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Keyboard.current.iKey.wasPressedThisFrame && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            animator.SetTrigger("Jump");
        }
        horizontalInput = Keyboard.current.jKey.isPressed ? -1 : Keyboard.current.lKey.isPressed ? 1 : 0;
        if (Keyboard.current.jKey.isPressed)
        {
            animator.SetBool("isWalking", true);
        }
        if (Keyboard.current.lKey.isPressed)
        {
            animator.SetBool("isWalking", true);
        }
        if (Keyboard.current.jKey.wasReleasedThisFrame)
        {
            animator.SetBool("isWalking", false);
        }
        if (Keyboard.current.lKey.wasReleasedThisFrame)
        {
            animator.SetBool("isWalking", false);
        }
        FlipSprite();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
