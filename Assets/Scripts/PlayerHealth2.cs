using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth2 : MonoBehaviour
{
    public static int maxHealth;
    public static int currentHealth;
    public static int Meleedamage;
    public static int Shotdamage;
    public Slider Health;
    Animator animator;
    PlayerAttack2 playerAttack2;
    PlayerType player;
    Timer timer;
    PlayerType playerType;

    void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
        playerAttack2 = GetComponent<PlayerAttack2>();
        player = GetComponent<PlayerType>();
    }

    void Update()
    {
        Health.maxValue = maxHealth;
        Health.value = currentHealth;

        if (currentHealth <= 0)
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
            if (playerAttack2.Defense == false)
            {
                currentHealth -= Meleedamage;
                animator.SetTrigger("Hit");
            }
            if (playerAttack2.Defense == true)
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
            if (playerAttack2.Defense == false)
            {
                currentHealth -= Shotdamage;
                animator.SetTrigger("Hit");
            }
            if (playerAttack2.Defense == true)
            {

            }
        }
    }
}