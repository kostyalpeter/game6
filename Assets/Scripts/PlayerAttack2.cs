using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerAttack2 : MonoBehaviour
{
    PlayerMovement2 playerMovement;
    PlayerType player;
    Animator animator;
    PlayerHealth1 playerHealth;
    public GameObject shot;
    public Vector3 offset1;
    public Vector3 offset2;
    public float timer;
    public float time = 3;
    public bool CoolDown = false;
    public bool canHit = false;
    public CircleCollider2D HitArea;
    public bool Sprint = false;
    public bool Hitting = false;

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
            PlayerHealth1.Meleedamage = 10;
            PlayerHealth1.Shotdamage = 20;
            playerMovement.moveSpeed = 6f;
            playerMovement.jumpForce = 5f;
        }
        if (player.playerType == PlayerType.PlayerTypes.Charachter4)
        {
            PlayerHealth1.Meleedamage = 10;
            PlayerHealth1.Shotdamage = 10;
            playerMovement.moveSpeed = 6f;
            playerMovement.jumpForce = 5f;
        }
        if (player.playerType == PlayerType.PlayerTypes.Charachter5)
        {
            PlayerHealth1.Meleedamage = 10;
            PlayerHealth1.Shotdamage = 10;
            playerMovement.moveSpeed = 6f;
            playerMovement.jumpForce = 5f;
        }
        if (player.playerType == PlayerType.PlayerTypes.Charachter6)
        {
            PlayerHealth1.Meleedamage = 10;
            PlayerHealth1.Shotdamage = 10;
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
        if (Keyboard.current.oKey.wasPressedThisFrame && CoolDown == true && player.playerType != PlayerType.PlayerTypes.Charachter3 && player.playerType != PlayerType.PlayerTypes.Charachter6)
        {
            animator.SetTrigger("Attack");
        }
        if (Keyboard.current.oKey.wasPressedThisFrame && CoolDown == true && player.playerType == PlayerType.PlayerTypes.Charachter3)
        {
            animator.SetTrigger("Attack");
            canHit = true;
        }
        if (Keyboard.current.oKey.wasPressedThisFrame && CoolDown == true && player.playerType == PlayerType.PlayerTypes.Charachter6)
        {
            animator.SetTrigger("Attack");
            canHit = true;
        }
        if (Keyboard.current.periodKey.wasPressedThisFrame && player.playerType != PlayerType.PlayerTypes.Charachter3 && player.playerType != PlayerType.PlayerTypes.Charachter6)
        {
            canHit = true;
            animator.SetTrigger("Attack2");
        }
        if (Keyboard.current.periodKey.wasPressedThisFrame && player.playerType == PlayerType.PlayerTypes.Charachter3)
        {
            if (timer >= 14)
            {
                animator.SetTrigger("Attack2");
                canHit = true;
                Sprint = true;
            }
        }
        if (Keyboard.current.periodKey.wasPressedThisFrame && player.playerType == PlayerType.PlayerTypes.Charachter6)
        {
            if (timer >= 14)
            {
                animator.SetTrigger("Attack2");
                canHit = true;
                Sprint = true;
            }
        }
        if (Keyboard.current.periodKey.wasReleasedThisFrame)
        {
            canHit = false;
        }
        if (timer >= 3)
        {
            Reverse.reverse = false;
        }
        if (timer >= 4 && playerMovement.moveSpeed == 7f)
        {
            animator.SetTrigger("Stop");
            playerMovement.moveSpeed = 6f;
            Sprint = false;
        }
        if (Sprint == true && timer >= 10 && player.playerType == PlayerType.PlayerTypes.Charachter3)
        {
            timer = 0;
            playerMovement.moveSpeed = 7f;
        }
        if (Sprint == true && timer >= 10 && player.playerType == PlayerType.PlayerTypes.Charachter6)
        {
            timer = 0;
            playerMovement.moveSpeed = 7f;
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
            GameObject a = Instantiate(shot, spawnPos, transform.rotation);
            a.GetComponent<Shoot>().SetDirection(playerMovement.isFacingRight);
        }
    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<PlayerHealth1>() && canHit == true && timer >= 1 && player.playerType != PlayerType.PlayerTypes.Charachter2 && player.playerType != PlayerType.PlayerTypes.Charachter3 && player.playerType != PlayerType.PlayerTypes.Charachter6)
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
        if (other.GetComponent<PlayerHealth1>() && canHit == true && timer >= 3 && player.playerType == PlayerType.PlayerTypes.Charachter3)
        {
            other.gameObject.GetComponent<PlayerHealth1>().MeleeDamage();
            canHit = false;
            timer = 1;
            Debug.Log("asdasd");
        }
        if (other.GetComponent<PlayerHealth1>() && canHit == true && timer >= 3 && player.playerType == PlayerType.PlayerTypes.Charachter6)
        {
            other.gameObject.GetComponent<PlayerHealth1>().MeleeDamage();
            canHit = false;
            timer = 1;
            Debug.Log("asdasd");
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (Sprint == true && other.GetComponent<PlayerHealth1>() && player.playerType == PlayerType.PlayerTypes.Charachter3)
        {
            other.gameObject.GetComponent<PlayerHealth1>().MeleeDamage();
            timer = 4;
        }
        if (Sprint == true && other.GetComponent<PlayerHealth1>() && player.playerType == PlayerType.PlayerTypes.Charachter6)
        {
            other.gameObject.GetComponent<PlayerHealth1>().MeleeDamage();
            timer = 4;
        }
    }
}