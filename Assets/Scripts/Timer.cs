using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Timer : MonoBehaviour
{
    public TMP_Text TimerText;
    float TimeLeft = 100;
    bool canCount = false;
    public TMP_Text Player1Text;
    public TMP_Text Player2Text;
    public static int Player1;
    public static int Player2;
    bool canAdd = true;
    public int Timing;
    bool newGame;


    void Start()
    {
        canCount = true;
        // canAdd = true;
        Timing = 1;
    }

    void Update()
    {
        if (canCount == true)
        {
            TimeLeft -= Time.deltaTime;
            TimerText.text = TimeLeft.ToString("F0");
        }

        if (TimeLeft <= 0)
        {
            Debug.Log("asd");
            canCount = false;
            Time.timeScale = 0f;
        }

        if (TimeLeft <= 0)
        {
            AddPoint();
        }
        Player1Text.text = Player1.ToString();
        Player2Text.text = Player2.ToString();
        Win1();
        Win2();
        // if (Timing == 0)
        // {
        //     SceneManager.LoadScene("Choose");
        // }
    }

    void AddPoint()
    {
        Time.timeScale = 1f;

        if (PlayerHealth1.currentHealth > PlayerHealth2.currentHealth && canAdd == true)
        {
            Player1 += 1;
            Debug.Log("Player 1 Won");
            canAdd = false;
            StartCoroutine(Wait());
        }
        if (PlayerHealth2.currentHealth > PlayerHealth1.currentHealth && canAdd == true)
        {
            Player2 += 1;
            Debug.Log("Player 2 Won");
            canAdd = false;
            StartCoroutine(Wait());
        }
        if (PlayerHealth2.currentHealth == PlayerHealth1.currentHealth)
        {
            Debug.Log("Tie");
            StartCoroutine(Wait());
        }
    }
    public void Win1()
    {
        if (PlayerHealth2.currentHealth <= 0 && canAdd == true)
        {
            Player1 += 1;
            Debug.Log("Player 1 Won");
            canCount = false;
            canAdd = false;
            Timing -= 1;
            StartCoroutine(Wait());
            PlayerHealth2.currentHealth += 1;
        }
    }
    public void Win2()
    {
        if (PlayerHealth1.currentHealth <= 0 && canAdd == true)
        {
            Player2 += 1;
            Debug.Log("Player 2 Won");
            canCount = false;
            canAdd = false;
            Timing -= 1;
            StartCoroutine(Wait());
            PlayerHealth1.currentHealth += 1;
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("Game");
        canCount = true;
    }
}
