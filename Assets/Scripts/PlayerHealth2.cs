using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth2 : MonoBehaviour
{
    public int maxHealth = 100;
    public static int currentHealth;
    public static int damage;
    public Slider Health;
    Animator animator;

    void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Health.maxValue = maxHealth;
        Health.value = currentHealth;

        if (currentHealth == 0)
        {
            animator.SetTrigger("Die");
        }

    }
    public void TakeDamage()
    {
        currentHealth -= damage;
        animator.SetTrigger("Hit");
    }

}
