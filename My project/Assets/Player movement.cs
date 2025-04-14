using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;


public class Playermovement : MonoBehaviour
{
    [SerializeField]private float speed = 5f;

    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator animator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void OnMovement (InputValue value)
    {
        movement = value.Get<Vector2>();

        if (movement.x != 0 || movement.y != 0) { 
            animator.SetFloat("X", movement.x);
            animator.SetFloat("Y", movement.y);

            animator.SetBool("IsWalking", true);
        }   else
        {
            animator.SetBool("IsWalking", false);
        }

    }
    private void FixedUpdate()
    {
        //Variant 1
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

        //Variant 2
        //if (movement.x != 0 || movement.y != 0)
        //{
        //    rb.velocity = movement * speed;
        //}

        //Variant 3
        //rb.AddForce(movement * speed);
    }
}
