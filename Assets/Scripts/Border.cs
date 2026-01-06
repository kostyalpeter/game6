using UnityEngine;

public class Border : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            PlayerHealth1.currentHealth -= 100;
        }
        if (other.CompareTag("Player2"))
        {
            PlayerHealth2.currentHealth -= 100;
        }
    }
}
