using UnityEngine;

public class Starts : MonoBehaviour
{
    public GameObject P1Ch1;
    public GameObject P1Ch2;
    public GameObject P1Ch3;
    public GameObject P1Ch4;
    public GameObject P1Ch5;
    public GameObject P1Ch6;
    public GameObject P1Ch7;
    public GameObject P1Ch8;
    public GameObject P1Ch9;
    public GameObject P1Ch10;
    public GameObject P1Ch11;
    public GameObject P1Ch12;
    public GameObject P2Ch1;
    public GameObject P2Ch2;
    public GameObject P2Ch3;
    public GameObject P2Ch4;
    public GameObject P2Ch5;
    public GameObject P2Ch6;
    public GameObject P2Ch7;
    public GameObject P2Ch8;
    public GameObject P2Ch9;
    public GameObject P2Ch10;
    public GameObject P2Ch11;
    public GameObject P2Ch12;
    public GameObject Map1;
    public GameObject Map21;
    public GameObject Map22;
    void Start()
    {
        //Maps

        if (Choose.Map == 1)
        {
            Map1.SetActive(true);
        }

        if (Choose.Map == 2)
        {
            Map21.SetActive(true);
            Map22.SetActive(true);
        }

        //Player 1

        if (Choose.Player1 == 1)
        {
            P1Ch1.SetActive(true);
        }
        if (Choose.Player1 == 2)
        {
            P1Ch2.SetActive(true);
        }
        if (Choose.Player1 == 3)
        {
            P1Ch3.SetActive(true);
        }
        if (Choose.Player1 == 4)
        {
            P1Ch4.SetActive(true);
        }
        if (Choose.Player1 == 5)
        {
            P1Ch5.SetActive(true);
        }
        if (Choose.Player1 == 6)
        {
            P1Ch6.SetActive(true);
        }
        if (Choose.Player1 == 7)
        {
            P1Ch7.SetActive(true);
        }
        if (Choose.Player1 == 8)
        {
            P1Ch8.SetActive(true);
        }
        if (Choose.Player1 == 9)
        {
            P1Ch9.SetActive(true);
        }
        if (Choose.Player1 == 10)
        {
            P1Ch10.SetActive(true);
        }
        if (Choose.Player1 == 11)
        {
            P1Ch11.SetActive(true);
        }
        if (Choose.Player1 == 12)
        {
            P1Ch12.SetActive(true);
        }
        //Player 2

        if (Choose.Player2 == 1)
        {
            P2Ch1.SetActive(true);
        }
        if (Choose.Player2 == 2)
        {
            P2Ch2.SetActive(true);
        }
        if (Choose.Player2 == 3)
        {
            P2Ch3.SetActive(true);
        }
        if (Choose.Player2 == 4)
        {
            P2Ch4.SetActive(true);
        }
        if (Choose.Player2 == 5)
        {
            P2Ch5.SetActive(true);
        }
        if (Choose.Player2 == 6)
        {
            P2Ch6.SetActive(true);
        }
        if (Choose.Player2 == 7)
        {
            P2Ch7.SetActive(true);
        }
        if (Choose.Player2 == 8)
        {
            P2Ch8.SetActive(true);
        }
        if (Choose.Player2 == 9)
        {
            P2Ch9.SetActive(true);
        }
        if (Choose.Player2 == 10)
        {
            P2Ch10.SetActive(true);
        }
        if (Choose.Player2 == 11)
        {
            P2Ch11.SetActive(true);
        }
        if (Choose.Player2 == 12)
        {
            P2Ch12.SetActive(true);
        }
    }
}