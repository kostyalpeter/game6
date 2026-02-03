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
        onKeys = false;
        MoveForward.text = "L";
        Back.text = "J";
        Jump.text = "I";
        Skill1.text = "O";
        Skill2.text = "Dot";
    }

    public void Changing1()
    {
        if (onKeys == false)
        {
            onKeys = true;
            MoveForward.text = "Right Arrow";
            Back.text = "Left Arrow";
            Jump.text = "Up Arrow";
            Skill1.text = "Number 1";
            Skill2.text = "Number 2";
        }
    }
    public void Changing2()
    {
        if (onKeys == true)
        {
            onKeys = false;
            MoveForward.text = "L";
            Back.text = "J";
            Jump.text = "I";
            Skill1.text = "O";
            Skill2.text = "Dot";
        }
    }
}
