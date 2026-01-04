using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    Animator animator;
    public GameObject arrow;
    public Vector3 offset;

    void Start()
    {
        animator = GetComponent<Animator>();
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
        Vector3 spawnPos = gameObject.transform.position + offset;
        Instantiate(arrow, spawnPos, gameObject.transform.rotation);
    }
}
