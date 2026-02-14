using UnityEngine;

public class Border : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.CompareTag("Player1") && other.CompareTag("Border"))
        {
            PlayerHealth1.currentHealth -= 100;
        }
        if (gameObject.CompareTag("Player2") && other.CompareTag("Border"))
        {
            PlayerHealth2.currentHealth -= 100;
        }
    }
}