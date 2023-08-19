using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    public Animator animator;

    private Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;

    private bool isSpacePressed = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.drag = 5f;
        rb.angularDrag = 5f;
    }

    private void Update()
    {
        int a = 0;

        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX, moveY);

        rb.velocity = movement * speed;

        if (movement.x > 0)
        {
            spriteRenderer.flipX = false;

        }
        else if (movement.x < 0)
        {
            spriteRenderer.flipX = true;
        }
    }
}
