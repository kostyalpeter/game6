using UnityEngine;

public class Choose : MonoBehaviour
{
    public static int Player1;
    public static int Player2;
    public static int Map;
    public void Random1()
    {
        Player1 = Random.Range(1, 13);
        Debug.Log(Player1);
    }
    public void Random2()
    {
        Player2 = Random.Range(1, 13);
        Debug.Log(Player2);
    }
    public void Maps()
    {
        Map = Random.Range(1, 3);
        Debug.Log(Map);
    }
    public void Map1()
    {
        Map = 1;
    }
    public void Map2()
    {
        Map = 2;
    }
    public void P1CH1()
    {
        Player1 = 1;
    }
    public void P1CH2()
    {
        Player1 = 2;
    }
    public void P1CH3()
    {
        Player1 = 3;
    }
    public void P1CH4()
    {
        Player1 = 4;
    }
    public void P1CH5()
    {
        Player1 = 5;
    }
    public void P1CH6()
    {
        Player1 = 6;
    }
    public void P1CH7()
    {
        Player1 = 7;
    }
    public void P1CH8()
    {
        Player1 = 8;
    }
    public void P1CH9()
    {
        Player1 = 9;
    }
    public void P1CH10()
    {
        Player1 = 10;
    }
    public void P1CH11()
    {
        Player1 = 11;
    }
    public void P1CH12()
    {
        Player1 = 12;
    }
    public void P2CH1()
    {
        Player2 = 1;
    }
    public void P2CH2()
    {
        Player2 = 2;
    }
    public void P2CH3()
    {
        Player2 = 3;
    }
    public void P2CH4()
    {
        Player2 = 4;
    }
    public void P2CH5()
    {
        Player2 = 5;
    }
    public void P2CH6()
    {
        Player2 = 6;
    }
    public void P2CH7()
    {
        Player2 = 7;
    }
    public void P2CH8()
    {
        Player2 = 8;
    }
    public void P2CH9()
    {
        Player2 = 9;
    }
    public void P2CH10()
    {
        Player2 = 10;
    }
    public void P2CH11()
    {
        Player2 = 11;
    }
    public void P2CH12()
    {
        Player2 = 12;
    }
}
