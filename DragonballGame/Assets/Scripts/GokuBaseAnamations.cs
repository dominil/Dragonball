using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GokuBaseAnamations : MonoBehaviour
{
    const string Goku_Base_Moving = "Moving";
    const string Goku_Base_FastMoving = "FastMoving";
    const string Goku_Base_Atak1 = "Atak1";
    const string Goku_Base_Atak2 = "Atak2";
    const string Goku_Base_Atak3 = "Atak3";
    const string Goku_Base_combo1 = "combo1";
    const string Goku_Base_combo2 = "combo2";
    const string Goku_Base_GenkiDama = "GenkiDama";
    const string Goku_Base_Kamehameha = "Kamehameha";
    const string Goku_Base_kiBlast = "kiBlast";
    const string Goku_Base_Dead = "Dead";
    const string Goku_Base_Idle = "Idle";
    private string currentState;

    PlayerMovement playermov;
    Animator animator;
    Rigidbody2D rb;
    void Start()
    {
        playermov = GetComponent<PlayerMovement>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {



        //input.getkeydown(keycode.a) || input.getkeydown(keycode.s) || input.getkeydown(keycode.w) || input.getkeydown(keycode.d)
        if (playermov.movement.x != 0||playermov.movement.y !=0)
        {
            ChangeAnimationState(Goku_Base_Moving);
        }
        else
        {
            ChangeAnimationState(Goku_Base_Idle);
        }
       
        
    }


    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        animator.Play(newState);

        currentState = newState;
    } 

}
