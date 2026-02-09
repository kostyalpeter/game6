using System.Collections;
using Unity.VisualScripting;
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
    public bool Check1;
    public bool Check2;
    public bool Check3;

    public void Start()
    {
        Check1 = true;
        Check2 = true;
        Check3 = true;
        Src.PlayOneShot(Click);
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

    }
    public void ClickSound()
    {
        Src.PlayOneShot(Click);
    }
    public void Interact1()
    {
        if (Check1 == true)
        {
            Check1 = false;
        }
        if (Check1 == false)
        {
            Check1 = true;
        }
    }
    public void Interact2()
    {
        if (Check2 == true)
        {
            CheckMark2.SetActive(false);
            Check2 = false;
        }
        if (Check2 == false)
        {
            CheckMark2.SetActive(true);
            Check2 = true;
        }
    }
    public void Interact3()
    {
        if (Check3 == true)
        {
            CheckMark3.SetActive(false);
            Check3 = false;
        }
        if (Check3 == false)
        {
            CheckMark3.SetActive(true);
            Check3 = true;
        }
    }

    // IEnumerator Wait1()
    // {
    //     yield return new WaitForSeconds(1f);
    //     if (Check1 == true)
    //     {
    //         CheckMark1.SetActive(false);
    //     }
    //     if (Check1 == false)
    //     {
    //         CheckMark1.SetActive(true);
    //     }
    // }
}
