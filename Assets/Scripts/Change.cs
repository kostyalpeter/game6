using UnityEngine;
using TMPro;

public class Change : MonoBehaviour
{
    public static bool onKeys;
    public TMP_Text MoveForward;
    public TMP_Text Back;
    public TMP_Text Jump;
    public TMP_Text Skill1;
    public TMP_Text Skill2;

    void Start()
    {
        MoveForward.text = "L";
        Back.text = "J";
        Jump.text = "I";
        Skill1.text = "O";
        Skill2.text = "Dot";
    }

    void Update()
    {
        if (onKeys == false)
        {
            MoveForward.text = "L";
            Back.text = "J";
            Jump.text = "I";
            Skill1.text = "O";
            Skill2.text = "Dot";
        }
        if (onKeys == true)
        {
            MoveForward.text = "Right Arrow";
            Back.text = "Left Arrow";
            Jump.text = "Up Arrow";
            Skill1.text = "Number 1";
            Skill2.text = "Number 2";
        }
    }

    public void Changing1()
    {
        if (onKeys == true)
        {
            MoveForward.text = "L";
            Back.text = "J";
            Jump.text = "I";
            Skill1.text = "O";
            Skill2.text = "Dot";
            onKeys = false;
        }
    }
    public void Changing2()
    {
        if (onKeys == false)
        {
            MoveForward.text = "Right Arrow";
            Back.text = "Left Arrow";
            Jump.text = "Up Arrow";
            Skill1.text = "Number 1";
            Skill2.text = "Number 2";
            onKeys = true;
        }
    }
}
