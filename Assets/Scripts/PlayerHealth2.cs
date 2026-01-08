using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth2 : MonoBehaviour
{
    public int maxHealth = 100;
    public static int currentHealth;
    public static int Meleedamage;
    public static int Shotdamage;
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
    public void MeleeDamage()
    {
        currentHealth -= Meleedamage;
        animator.SetTrigger("Hit");
    }
    public void ShotDamage()
    {
        currentHealth -= Shotdamage;
        animator.SetTrigger("Hit");
    }
}
