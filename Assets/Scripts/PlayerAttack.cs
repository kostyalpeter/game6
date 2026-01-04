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

    void Start()
    {
        animator = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }
    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
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

        if (playerMovement.isFacingRight == true)
        {
            spawnPos = transform.position + offset2;
        }
        else
        {
            spawnPos = transform.position + offset1;
        }
        GameObject a = Instantiate(arrow, spawnPos, transform.rotation);
        a.GetComponent<Arrow>().SetDirection(playerMovement.isFacingRight);
    }
}
