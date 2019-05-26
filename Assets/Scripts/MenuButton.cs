using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField] MenuButtonController menuButtonController;
    public Animator animator;
    [SerializeField] AnimatorFunctions animatorFunctions;
    [SerializeField] int thisIndex;
    public Rigidbody2D miwan;



    // Update is called once per frame
    void Update()
    {
        if (menuButtonController.index == thisIndex)
        {
            animator.SetBool("selected", true);
            if (Input.GetAxis("Submit") == 1)
            {
                animator.SetBool("pressed", true);
            }
            else if (animator.GetBool("pressed"))
            {
                animator.SetBool("pressed", false);
                animatorFunctions.disableOnce = true;

                if (thisIndex == 0)
                {
                    menuButtonController.canvas.enabled = false;
                    miwan = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
                    miwan.isKinematic = false;
                }
                else if (thisIndex == 2) Application.Quit();
            }


        }
        else
        {
            animator.SetBool("selected", false);
        }
    }

}
