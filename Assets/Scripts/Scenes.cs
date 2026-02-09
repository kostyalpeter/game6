using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Characters()
    {
        SceneManager.LoadScene("Characters");
    }
    public void Game()
    {
        SceneManager.LoadScene("Choose");
    }
    public void Choose1()
    {
        SceneManager.LoadScene("Choose");
    }
    public void Play()
    {
        if (Choose.Player1 != 0 && Choose.Player2 != 0 && Choose.Map != 0)
        {
            SceneManager.LoadScene("Game");
        }
    }

    public void SetNull()
    {
        Timer.Player1 = 0;
        Timer.Player2 = 0;
    }

}