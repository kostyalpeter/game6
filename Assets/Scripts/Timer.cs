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
    bool canAdd;
    public int Timing;
    bool newGame;
    WinMusic winMusic;


    void Start()
    {
        if (Player1 == 0 && Player2 == 0)
        {
            newGame = true;
            Timing = 2;
        }
        else
        {
            newGame = false;
        }
        canCount = true;
        StartCoroutine(Wait2());
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
        //Time finished

        Time.timeScale = 1f;

        if (PlayerHealth1.currentHealth > PlayerHealth2.currentHealth && canAdd == true)
        {
            Player1 += 1;
            Debug.Log("Player 1 Won");
            canAdd = false;
            StartCoroutine(Wait());
            Timing -= 1;
        }
        if (PlayerHealth2.currentHealth > PlayerHealth1.currentHealth && canAdd == true)
        {
            Player2 += 1;
            Debug.Log("Player 2 Won");
            canAdd = false;
            StartCoroutine(Wait());
            Timing -= 1;
        }
        if (PlayerHealth2.currentHealth == PlayerHealth1.currentHealth)
        {
            Debug.Log("Tie");
            StartCoroutine(Wait());
            Timing -= 1;
        }
    }
    public void Win1()
    {
        //Normal end

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
        if (Timing > 0)
        {
            SceneManager.LoadScene("Game");
        }
        else
        {
            SceneManager.LoadScene("Choose");
        }
        canCount = true;
        winMusic.Randomize();
        winMusic.PlaySong();    
    }
    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(1f);
        canAdd = true;
    }
}
