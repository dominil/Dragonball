using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GokuBaseAnamations : MonoBehaviour
{


    PlayerMovement playermov;
    Animator animator;
    Rigidbody2D rb;

    

    void Start()
    {
        playermov = GetComponent<PlayerMovement>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        if (playermov.movement != new Vector2(0, 0))
        {
            SetRun();
        }
        else
        {
            SetRunNo();
        }
    }
    public void SetIdle()
    {
        animator.SetBool("idle", true);
    }
    public void SetRun()
    {
        animator.SetBool("ruszasie", true);
    }
    public void SetRunNo()
    {
        animator.SetBool("ruszasie", false);
    }

    public void setunenabledMove()
    {
        playermov.enabled=false;
    }
    public void setenablemove()
    {
        playermov.enabled = true;
    }
    public void setgenkidown()
    {
        animator.SetBool("genki", false);
    }
    public void setkamehamehadown()
    {
        animator.SetBool("kamehameha", false);
    }
    public void setatakdown()
    {
        animator.SetBool("atak", false);
    }

}
