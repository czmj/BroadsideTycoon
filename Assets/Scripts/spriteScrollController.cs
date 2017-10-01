using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteScrollController : MonoBehaviour
{
    public float speed = 1.0f;
    public float whenStatic = 0.0f;
    private Vector2 velocity = new Vector2(0.0f, 0.0f);
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start ()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        var horizontal = Input.GetAxis("Horizontal");

        if (horizontal > 0 || whenStatic != 0.0f)
        {
            velocity.Set(speed + whenStatic, 0.0f);
        }
        else if (horizontal < 0 || whenStatic != 0.0f)
        {
            velocity.Set(-speed + whenStatic, 0.0f);
        }
        else
        {
            velocity.Set(0.0f, 0.0f);
        }

        rb2d.MovePosition(rb2d.position + velocity * Time.fixedDeltaTime);

    }
}
