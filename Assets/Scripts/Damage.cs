using UnityEngine;

public class Damage : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1") || other.CompareTag("Player2"))
        {
            PlayerHealth.currentHealth -= 10;
        }
    }
}
