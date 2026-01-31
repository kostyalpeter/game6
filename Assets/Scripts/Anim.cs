using UnityEngine;

public class Anim : MonoBehaviour
{
    Player player;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Update()
    {
        if (Player.Anim == 1)
        {
            animator.SetTrigger("Player1");
        }
        if (Player.Anim == 2)
        {
            animator.SetTrigger("Player2");
        }
        else if (Player.Anim == 3)
        {
            animator.SetTrigger("Player3");
        }
        else if (Player.Anim == 4)
        {
            animator.SetTrigger("Player4");
        }
        else if (Player.Anim == 5)
        {
            animator.SetTrigger("Player5");
        }
        else if (Player.Anim == 6)
        {
            animator.SetTrigger("Player6");
        }
        else if (Player.Anim == 7)
        {
            animator.SetTrigger("Player7");
        }
        else if (Player.Anim == 8)
        {
            animator.SetTrigger("Player8");
        }
        else if (Player.Anim == 9)
        {
            animator.SetTrigger("Player9");
        }
        else if (Player.Anim == 10)
        {
            animator.SetTrigger("Player10");
        }
        else if (Player.Anim == 11)
        {
            animator.SetTrigger("Player11");
        }
        else if (Player.Anim == 12)
        {
            animator.SetTrigger("Player12");
        }
    }
}
