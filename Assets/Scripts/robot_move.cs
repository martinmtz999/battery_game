using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot_move : MonoBehaviour
{

    float speedX;
    float speedY;
    public float speed;
    Rigidbody2D rb;
    private bool isFacingRight = true;
    public float jump;

    public Transform inGround;
    public LayerMask groundLayer;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics2D.OverlapCapsule(
            inGround.position,
            new Vector2(2.5f, 1.0f),
            CapsuleDirection2D.Horizontal,
            0,
            groundLayer
            );
        Debug.Log("isGrounded = " + isGrounded);
        Debug.Log("Velocity = " + rb.velocity);



        float horizontalInput = Input.GetAxisRaw("Horizontal") * speed;

        Vector2 currentVelocity = rb.velocity;

        currentVelocity.x = horizontalInput;

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            currentVelocity.y = jump;
        }

        rb.velocity = currentVelocity;

        Flip();

    }

    private void Flip()
    {
        if ((isFacingRight && rb.velocity.x > 0f) ||
            (!isFacingRight && rb.velocity.x < 0f))
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }

    }
}