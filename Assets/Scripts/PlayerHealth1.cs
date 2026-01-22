using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth1 : MonoBehaviour
{
    public int maxHealth = 100;
    public static int currentHealth;
    public static int Meleedamage;
    public static int Shotdamage;
    public Slider Health;
    Animator animator;
    PlayerAttack1 playerAttack1;
    PlayerType player;

    void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
        playerAttack1 = GetComponent<PlayerAttack1>();
        player = GetComponent<PlayerType>();
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
        if (player.playerType != PlayerType.PlayerTypes.Charachter10)
        {
            currentHealth -= Meleedamage;
            animator.SetTrigger("Hit");
        }
        if (player.playerType == PlayerType.PlayerTypes.Charachter10)
        {
            if (playerAttack1.Defense == false)
            {
                currentHealth -= Meleedamage;
                animator.SetTrigger("Hit");
            }
            if (playerAttack1.Defense == true)
            {

            }
        }

    }
    public void ShotDamage()
    {
        if (player.playerType != PlayerType.PlayerTypes.Charachter10)
        {
            currentHealth -= Shotdamage;
            animator.SetTrigger("Hit");
        }
        if (player.playerType == PlayerType.PlayerTypes.Charachter10)
        {
            if (playerAttack1.Defense == false)
            {
                currentHealth -= Shotdamage;
                animator.SetTrigger("Hit");
            }
            if (playerAttack1.Defense == true)
            {

            }
        }
    }
}
