using UnityEngine;

public class Anim : MonoBehaviour
{
    Player player;
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Update()
    {
        if (Player.Anim == 1)
        {
            animator.Play("Player1");
        }
        else if (Player.Anim == 2)
        {
            animator.Play("Player2");
        }
        else if (Player.Anim == 3)
        {
            animator.Play("Player3");
        }
        else if (Player.Anim == 4)
        {
            animator.Play("Player4");
        }
        else if (Player.Anim == 5)
        {
            animator.Play("Player5");
        }
        else if (Player.Anim == 6)
        {
            animator.Play("Player6");
        }
        else if (Player.Anim == 7)
        {
            animator.Play("Player7");
        }
        else if (Player.Anim == 8)
        {
            animator.Play("Player8");
        }
        else if (Player.Anim == 9)
        {
            animator.Play("Player9");
        }
        else if (Player.Anim == 10)
        {
            animator.Play("Player10");
        }
        else if (Player.Anim == 11)
        {
            animator.Play("Player11");
        }
        else if (Player.Anim == 12)
        {
            animator.Play("Player12");
        }
    }
}
