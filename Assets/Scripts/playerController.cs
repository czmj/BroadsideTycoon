using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float walkSpeed = 1.0f;
    private Vector2 velocity = new Vector2(0.0f, 0.0f);
    private Rigidbody2D rb2d;
    private Animator animator;

    // Use this for initialization
    void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        this.Walk();
    }

    void Walk()
    {
        var horizontal = Input.GetAxis("Horizontal");

        if (horizontal > 0)
        {
            animator.SetInteger("walkDirection", 1);
            animator.enabled = true;
            velocity.Set(walkSpeed, 0.0f);
        }
        else if (horizontal < 0)
        {
            animator.SetInteger("walkDirection", 3);
            animator.enabled = true;
            velocity.Set(-walkSpeed, 0.0f);
        }
        else
        {
            animator.enabled = false;
            velocity.Set(0.0f, 0.0f);
        }

        rb2d.MovePosition(rb2d.position + velocity * Time.fixedDeltaTime);
    }
}