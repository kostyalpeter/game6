using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth1 : MonoBehaviour
{
    public int maxHealth = 100;
    public static int currentHealth;
    public Slider Health;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        Health.maxValue = maxHealth;
        Health.value = currentHealth;
    }
}
