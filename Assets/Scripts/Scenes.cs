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
        SceneManager.LoadScene("Game");
    }
    public void Choose()
    {
        SceneManager.LoadScene("Choose");
    }
}