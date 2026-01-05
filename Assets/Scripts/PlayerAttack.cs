using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    PlayerMovement playerMovement;
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
        playerMovement = GetComponent<PlayerMovement>();
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
        if (Keyboard.current.eKey.wasPressedThisFrame && CoolDown == true)
        {
            animator.SetTrigger("Attack");
        }
        if (Keyboard.current.cKey.wasPressedThisFrame)
        {
            animator.SetTrigger("Attack2");
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
            a.GetComponent<Arrow>().SetDirection(playerMovement.isFacingRight);
        }
    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player2") && canHit == true)
        {
            PlayerHealth.currentHealth -= 10;
        }
    }
    public void CanHit()
    {
        canHit = true;
    }
    public void CanHitOff()
    {
        canHit = false;
    }
}