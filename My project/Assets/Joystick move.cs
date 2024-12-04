using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMove : MonoBehaviour
{
    public JoystickMove movementJoystick;
    public float playerSpeed;
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        if (movementJoystick.transform.position.y != 0)
        {
            rb.velocity = new Vector2(movementJoystick.transform.position.x * playerSpeed, movementJoystick.transform.position.y * playerSpeed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}