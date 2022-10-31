using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public Vector2 movement;
    private bool facingright=true;
    private Rigidbody2D rb;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.deltaTime);
        if(movement.x<0 && facingright)
        {
            Flip();
        }else if(movement.x>0 && !facingright){
            Flip();
        }
        
    }

    void Flip()
    {
        facingright = !facingright;
        transform.Rotate(0f, 180f, 0f);
    }

}
