using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    //Animation variables
    private SpriteRenderer spriteRenderer;
    public SpriteRenderer flashlightSprite;
    // Movement variables
    public float moveSpeed = 15f;
    public float jumpForce = 15f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public Animator animator;
    public Transform flashlight;
    

    private Rigidbody2D rb;
    private bool isGrounded;
    private float groundCheckRadius = .2f;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        
        
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        
        

        // Handle horizontal movement
        float moveInput = Input.GetAxis("Horizontal");
        Vector2 moveVelocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        rb.velocity = moveVelocity;

        // Handle Animation
        if (moveInput > 0)
        {
            spriteRenderer.flipX = false;
            flashlight.localScale = new Vector3( 1, 1, 1);
        }
        else if (moveInput < 0)
        {
            spriteRenderer.flipX = true;
            flashlight.localScale = new Vector3(-1, 1, 1);

        }
        animator.SetFloat("player_Speed", Mathf.Abs(moveInput));

        // Handle jumping
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;
            animator.SetBool("isJump", true);
        }
        


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        animator.SetBool("isJump", false);
    }
    

    
}

