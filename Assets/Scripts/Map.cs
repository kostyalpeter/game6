using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject map1;
    public GameObject map2;
    void Update()
    {
        if(Choose.Map == 1)
        {
            map1.gameObject.SetActive(true);
            map2.gameObject.SetActive(false);
        }
        if(Choose.Map == 2)
        {
            map1.gameObject.SetActive(false);
            map2.gameObject.SetActive(true);
        }
    }
}
