using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack1 : MonoBehaviour
{
    PlayerMovement1 playerMovement;
    PlayerType player;
    Animator animator;
    public GameObject arrow;
    public Vector3 offset1;
    public Vector3 offset2;
    public float timer;
    public float time = 3;
    public bool CoolDown1 = false;
    public bool canHit1 = false;
    public CircleCollider2D HitArea;
    void Start()
    {
        animator = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement1>();
        player = GetComponent<PlayerType>();

        if(player.playerType == PlayerType.PlayerTypes.Charachter1)
        {
            PlayerHealth2.damage = 10;
            playerMovement.moveSpeed = 5f;
            playerMovement.jumpForce = 7f;
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
        }
        if (Keyboard.current.cKey.wasReleasedThisFrame)
        {
            canHit1 = false;
        }
    }
    public void SpawnArrow()
    {
        Vector3 spawnPos;
        if (CoolDown1== true)
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
            GameObject a = Instantiate(arrow, spawnPos, transform.rotation);
            a.GetComponent<Arrow>().SetDirection(playerMovement.isFacingRight1);
        }
    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<PlayerHealth2>() && canHit1 == true && timer >= 1)
        {
            other.gameObject.GetComponent<PlayerHealth2>().TakeDamage();
            timer = 0;
        }
    }
}