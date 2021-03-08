using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{
    // public GameManager gameManager;
    Rigidbody2D player;
    SpriteRenderer playerSprite;
    public LayerMask floorLayer;
    public Transform floorCheck;
    float floorCircumference = 0.15f;
    public float speed;
    public float height;
    float move;
    bool fliped;
    bool canJump = true;
    bool grounded = true;
    private Animator animator;

    public void Start()
    {
        player = GetComponent <Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    public void Update()
    {
        move = Input.GetAxis("Horizontal");
    }

    public void FixedUpdate()
    {
        movement();
        jump();
        flip();
    }

    void movement()
    {
        player.velocity = new Vector2(move * speed, player.velocity.y);
        if (move != 0)
        {
            animator.SetBool("isRunning", true);
        }
        else animator.SetBool("isRunning", false);
    }

    void flip()
    {
        if (move < 0 && !fliped)
        {
            fliped = !fliped;
            playerSprite.flipX = !playerSprite.flipX;
        }
        else if (move > 0 && fliped)
        {
            fliped = !fliped;
            playerSprite.flipX = !playerSprite.flipX;
        }
    }

    void jump()
    {
        if (canJump && grounded && Input.GetAxis("Jump") > 0)
        {
            player.velocity = new Vector2(player.velocity.x, 0f);
            player.AddForce(new Vector2(0, height), ForceMode2D.Impulse);
            grounded = false;
            animator.SetBool("isJumping", !grounded);
        }

        grounded = Physics2D.OverlapCircle(floorCheck.position, floorCircumference, floorLayer);
        animator.SetBool("isJumping", !grounded);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Lava") || collision.gameObject.CompareTag("Spike"))
        {
           // gameManager.GameOver();
        }
        else if (collision.gameObject.CompareTag("Apple"))
        {
           // Scoreboard.score++;
            Destroy(collision.GetComponent<Collider2D>());
            collision.GetComponent<Animator>().SetBool("Picked", true);

        }
    }
}
