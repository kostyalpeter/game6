using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack1 : MonoBehaviour
{
    PlayerMovement1 playerMovement;
    PlayerType player;
    Reverse reverse;
    Animator animator;
    public GameObject shot;
    public Vector3 offset1;
    public Vector3 offset2;
    public float timer;
    public float time = 3;
    public bool CoolDown1 = false;
    public bool canHit1 = false;
    public CircleCollider2D HitArea;
    public bool Sprint = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement1>();
        player = GetComponent<PlayerType>();
        reverse = GetComponent<Reverse>();

        if (player.playerType == PlayerType.PlayerTypes.Charachter1)
        {
            PlayerHealth2.Meleedamage = 10;
            PlayerHealth2.Shotdamage = 10;
            playerMovement.moveSpeed = 5f;
            playerMovement.jumpForce = 7f;
        }
        if (player.playerType == PlayerType.PlayerTypes.Charachter2)
        {
            PlayerHealth2.Meleedamage = 10;
            PlayerHealth2.Shotdamage = 10;
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
            CoolDown1 = true;
        }
        if (Keyboard.current.eKey.wasPressedThisFrame && CoolDown1 == true)
        {
            animator.SetTrigger("Attack");
        }
        if (Keyboard.current.cKey.wasPressedThisFrame)
        {
            animator.SetTrigger("Attack2");
            canHit1 = true;
            Sprint = true;
        }
        if (Keyboard.current.cKey.wasReleasedThisFrame)
        {
            canHit1 = false;
        }
        if (timer >= 3)
        {
            Reverse.reverse = false;
        }
        if (timer >= 4 && Sprint == true)
        {
            animator.SetTrigger("Stop");
            playerMovement.moveSpeed = 6f;
        }
        if (Sprint == true && timer >= 10 && player.playerType == PlayerType.PlayerTypes.Charachter3)
        {
            timer = 0;
            playerMovement.moveSpeed = 7f;
        }
    }
    public void SpawnArrow()
    {
        Vector3 spawnPos;
        if (CoolDown1 == true)
        {
            if (playerMovement.isFacingRight1 == true)
            {
                spawnPos = transform.position + offset2;
                CoolDown1 = false;
                timer = 0;
            }
            else
            {
                spawnPos = transform.position + offset1;
                CoolDown1 = false;
                timer = 0;
            }
            GameObject a = Instantiate(shot, spawnPos, transform.rotation);
            a.GetComponent<Shoot>().SetDirection(playerMovement.isFacingRight1);
        }
    }

    public void Hit()
    {
        if (CoolDown1 == true)
        {
            CoolDown1 = false;
            timer = 2;
        }

    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<PlayerHealth2>() && canHit1 == true && timer >= 1 && player.playerType != PlayerType.PlayerTypes.Charachter2 && player.playerType != PlayerType.PlayerTypes.Charachter3)
        {
            other.gameObject.GetComponent<PlayerHealth2>().MeleeDamage();
            timer = 0;
        }
        if (other.GetComponent<PlayerHealth2>() && canHit1 == true && timer >= 15 && playerMovement.isGrounded && player.playerType == PlayerType.PlayerTypes.Charachter2)
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
    public void OnTriggerEnter2D(Collider2D other)
    {
    }
}