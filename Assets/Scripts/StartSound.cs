using UnityEngine;

public class StartSound : MonoBehaviour
{
    public AudioSource Src;
    public AudioClip Song;
    public GameObject SongManager;
    void Start()
    {
        SongManager.SetActive(true);
        if (Sound.Check3 == true)
        {
            Src.PlayOneShot(Song);
        }
        else { }
    }
}
