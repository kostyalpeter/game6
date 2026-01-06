using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement1 : MonoBehaviour
{
    public float horizontalInput;
    public float jumpForce = 4f;
    public float moveSpeed = 5f;
    public bool isFacingRight1 = false;
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
        if (Keyboard.current.wKey.wasPressedThisFrame && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            animator.SetTrigger("Jump");
        }
        horizontalInput = Keyboard.current.aKey.isPressed ? -1 : Keyboard.current.dKey.isPressed ? 1 : 0;
        if (Keyboard.current.aKey.isPressed)
        {
            animator.SetBool("isWalking", true);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            animator.SetBool("isWalking", true);
        }
        if (Keyboard.current.aKey.wasReleasedThisFrame)
        {
            animator.SetBool("isWalking", false);
        }
        if (Keyboard.current.dKey.wasReleasedThisFrame)
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
        if (isFacingRight1 && horizontalInput > 0f || !isFacingRight1 && horizontalInput < 0f)
        {
            isFacingRight1 = !isFacingRight1;
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
