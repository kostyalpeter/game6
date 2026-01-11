using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack2 : MonoBehaviour
{
    PlayerMovement2 playerMovement;
    PlayerType player;
    Animator animator;
    public GameObject arrow;
    public Vector3 offset1;
    public Vector3 offset2;
    public float timer;
    public float time = 3;
    public bool CoolDown = false;
    public bool canHit = false;
    public CircleCollider2D HitArea;
    void Start()
    {
        animator = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement2>();
        player = GetComponent<PlayerType>();

        if (player.playerType == PlayerType.PlayerTypes.Charachter1)
        {
            PlayerHealth1.Meleedamage = 10;
            PlayerHealth1.Shotdamage = 10;
            playerMovement.moveSpeed = 5f;
            playerMovement.jumpForce = 7f;
        }
        if (player.playerType == PlayerType.PlayerTypes.Charachter1)
        {
            PlayerHealth1.Meleedamage = 10;
            PlayerHealth1.Shotdamage = 10;
            playerMovement.moveSpeed = 5f;
            playerMovement.jumpForce = 7f;
        }
        if (player.playerType == PlayerType.PlayerTypes.Charachter3)
        {
            PlayerHealth2.Meleedamage = 10;
            PlayerHealth2.Shotdamage = 10;
            playerMovement.moveSpeed = 6f;
            playerMovement.jumpForce = 5f;
        }

    }
    void Update()
    {
        if (timer >= 0)
        {
            timer += Time.deltaTime;
        }
        if (timer >= time)
        {
            CoolDown = true;
        }
        if (Keyboard.current.oKey.wasPressedThisFrame && CoolDown == true)
        {
            animator.SetTrigger("Attack");
        }
        if (Keyboard.current.periodKey.wasPressedThisFrame)
        {
            animator.SetTrigger("Attack2");
            canHit = true;
        }
        if (Keyboard.current.periodKey.wasReleasedThisFrame)
        {
            canHit = false;
        }
        if (timer >= 3)
        {
            Reverse.reverse = false;
        }
    }
    public void SpawnArrow()
    {
        Vector3 spawnPos;
        if (CoolDown == true)
        {
            if (playerMovement.isFacingRight == true)
            {
                spawnPos = transform.position + offset2;
                CoolDown = false;
                timer = 0;
            }
            else
            {
                spawnPos = transform.position + offset1;
                CoolDown = false;
                timer = 0;
            }
            GameObject a = Instantiate(arrow, spawnPos, transform.rotation);
            a.GetComponent<Shoot>().SetDirection(playerMovement.isFacingRight);
        }
    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<PlayerHealth1>() && canHit == true && timer >= 1 && player.playerType != PlayerType.PlayerTypes.Charachter2)
        {
            other.gameObject.GetComponent<PlayerHealth1>().MeleeDamage();
            timer = 0;
        }
        if (other.GetComponent<PlayerHealth1>() && canHit == true && timer >= 15 && playerMovement.isGrounded && player.playerType == PlayerType.PlayerTypes.Charachter2)
        {
            if (Reverse.reverse == true)
            {
                Reverse.reverse = false;
            }
            else
            {
                Reverse.reverse = true;
            }
            timer = 0;
            Debug.Log("asd");
        }
    }
}