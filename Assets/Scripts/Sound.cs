using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource Src;
    public AudioClip Click;
    public bool WinSound;
    public bool SFX;
    public bool Music;
    public GameObject CheckMark1;
    public GameObject CheckMark2;
    public GameObject CheckMark3;
    public static bool Check1 = true;
    public static bool Check2 = true;
    public static bool Check3 = true;

    public void Start()
    {
        if (Check2 == true)
        {
            Src.PlayOneShot(Click);
        }
        else { }
    }

    void Update()
    {
        if (Check1 == true)
        {
            CheckMark1.SetActive(true);
        }
        if (Check1 == false)
        {
            CheckMark1.SetActive(false);
        }
        if (Check2 == true)
        {
            CheckMark2.SetActive(true);
        }
        if (Check2 == false)
        {
            CheckMark2.SetActive(false);
        }
        if (Check3 == true)
        {
            CheckMark3.SetActive(true);
        }
        if (Check3 == false)
        {
            CheckMark3.SetActive(false);
        }
    }
    public void ClickSound()
    {
        if (Check2 == true)
        {
            Src.PlayOneShot(Click);
        }
        else { }
    }
    public void Interact1()
    {
        if (Check1 == true)
        {
            Check1 = false;
        }
        else
        {
            Check1 = true;
        }
    }
    public void Interact2()
    {
        if (Check2 == true)
        {
            Check2 = false;
        }
        else if (Check2 == false)
        {
            Check2 = true;
        }
    }
    public void Interact3()
    {
        if (Check3 == true)
        {
            Check3 = false;
        }
        else if (Check3 == false)
        {
            Check3 = true;
        }
    }
}