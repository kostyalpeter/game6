using UnityEngine;

public class WinMusic : MonoBehaviour
{
    public AudioClip Song1;
    public AudioClip Song2;
    public AudioClip Song3;
    public AudioClip Song4;
    public AudioClip Song5;
    public AudioSource Src;
    public int RandomSong;

    public void Randomize()
    {
        RandomSong = Random.Range(1, 6);
        Debug.Log(RandomSong);
    }
    public void PlaySong()
    {
        if (RandomSong == 1)
        {
            Src.clip = Song1;
            Src.Play();
        }
        if (RandomSong == 2)
        {
            Src.clip = Song2;
            Src.Play();
        }
        if (RandomSong == 3)
        {
            Src.clip = Song3;
            Src.Play();
        }
        if (RandomSong == 4)
        {
            Src.clip = Song4;
            Src.Play();
        }
        if (RandomSong == 5)
        {
            Src.clip = Song5;
            Src.Play();
        }
    }
}
