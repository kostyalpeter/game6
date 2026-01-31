using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TMP_Text Text;
    public TMP_Text Health;
    public TMP_Text Attack1;
    public TMP_Text Attack2;
    public TMP_Text Attack1Skill;
    public TMP_Text Attack2Skill;
    public TMP_Text Difficulty;
    public static int Anim;
    public GameObject AnimObject;
    void Start()
    {
        Anim = 0;
        AnimObject.SetActive(false);
        Text.gameObject.SetActive(false);
    }
    void Update()
    {
        if (Anim > 0)
        {
            AnimObject.SetActive(true);
            Text.gameObject.SetActive(true);
        }
    }
    public void Player1()
    {
        Health.text = "200";
        Attack1.text = "Has";
        Attack2.text = "Has";
        Attack1Skill.text = "Shoots an arrow that deals 20 damage.";
        Attack2Skill.text = "Hit with the bow, dealing 10 damage.";
        Difficulty.text = "Easy";
        Anim = 1;
    }
    public void Player2()
    {
        Health.text = "220";
        Attack1.text = "Has";
        Attack2.text = "Has";
        Attack1Skill.text = "Shoots a fireball that deals 25 damage.";
        Attack2Skill.text = "For a few seconds, reverts all of the projectile's movement.";
        Difficulty.text = "Medium";
        Anim = 2;
    }
    public void Player3()
    {
        Health.text = "230";
        Attack1.text = "Has";
        Attack2.text = "Has";
        Attack1Skill.text = "Hits with it's weapon, dealing 10 damage.";
        Attack2Skill.text = "Starts running with the horse, at collision with enemy player deals 30 damage.";
        Difficulty.text = "Medium";
        Anim = 3;
    }
    public void Player4()
    {
        Health.text = "180";
        Attack1.text = "Has";
        Attack2.text = "Has";
        Attack1Skill.text = "Shoots an arrow that deals 20 damage.";
        Attack2Skill.text = "Hit with the crossbow, dealing 10 damage.";
        Difficulty.text = "Medium";
        Anim = 4;
    }
    public void Player5()
    {
        Health.text = "200";
        Attack1.text = "Don't Has";
        Attack2.text = "Has";
        Attack1Skill.text = "-";
        Attack2Skill.text = "Hits with it's weapon, dealing 25 damage.";
        Difficulty.text = "Medium";
        Anim = 5;
    }
    public void Player6()
    {
        Health.text = "210";
        Attack1.text = "Has";
        Attack2.text = "Has";
        Attack1Skill.text = "Hits with it's weapon, dealing 10 damage.";
        Attack2Skill.text = "Starts running with the horse, at collision with enemy player deals 25 damage.";
        Difficulty.text = "Hard";
        Anim = 6;
    }
    public void Player7()
    {
        Health.text = "180";
        Attack1.text = "Has";
        Attack2.text = "Has";
        Attack1Skill.text = "Drinks a potion that heals 20 health.";
        Attack2Skill.text = "Hits with it's sword, dealing 15 damage.";
        Difficulty.text = "Hard";
        Anim = 7;
    }
    public void Player8()
    {
        Health.text = "100";
        Attack1.text = "Has";
        Attack2.text = "Has";
        Attack1Skill.text = "Shoots a fireball that deals 20 damage.";
        Attack2Skill.text = "Hits at the ground, creating a little explosion that deals 15 damage.";
        Difficulty.text = "Medium";
        Anim = 8;
    }
    public void Player9()
    {
        Health.text = "190";
        Attack1.text = "Don't Has";
        Attack2.text = "Has";
        Attack1Skill.text = "-";
        Attack2Skill.text = "Hits with it's sword, dealing 15 damage.";
        Difficulty.text = "Hard";
        Anim = 9;
    }
    public void Player10()
    {
        Health.text = "200";
        Attack1.text = "Has";
        Attack2.text = "Has";
        Attack1Skill.text = "Pull out it's shield, making it invincible for a few seconds.";
        Attack2Skill.text = "Hits with it's sword, dealing 15 damage.";
        Difficulty.text = "Medium";
        Anim = 10;
    }
    public void Player11()
    {
        Health.text = "200";
        Attack1.text = "Don't Has";
        Attack2.text = "Has";
        Attack1Skill.text = "-";
        Attack2Skill.text = "Hits with it's sword, dealing 15 damage.";
        Difficulty.text = "Hard";
        Anim = 11;
    }
    public void Player12()
    {
        Health.text = "200";
        Attack1.text = "Don't Has";
        Attack2.text = "Has";
        Attack1Skill.text = "-";
        Attack2Skill.text = "Hits with it's sword, dealing 15 damage.";
        Difficulty.text = "Hard";
        Anim = 12;
    }

}