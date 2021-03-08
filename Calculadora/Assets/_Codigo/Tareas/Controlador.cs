using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    // public GameManager gameManager;
    Rigidbody2D player;
    SpriteRenderer playerSprite;
    public LayerMask capasuelo;
    public Transform checarsuelo;
    float revisarsuelo = 0.15f;
    bool volteado, puedeSaltar = true, suelo = false;
    public float velocidad, altura;
    float mover;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent < Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        mover = Input.GetAxis("Horizontal");    
    }

    public void FixedUpdate()
    {
        movimiento();
        salto();
        girar();
    }

    void movimiento()
    {
        player.velocity = new Vector2(mover * velocidad, player.velocity.y);
        if (mover != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else anim.SetBool("isRunning", false);
    }

    void girar()
    {
        if (mover < 0 && !volteado)
        {
            volteado = !volteado;
            playerSprite.flipX = !playerSprite.flipX;
        } else if (mover > 0 && volteado)
        {
            volteado = !volteado;
            playerSprite.flipX = !playerSprite.flipX;
        }
    }

    void salto()
    {
        if (puedeSaltar && suelo && Input.GetAxis("Jump") > 0)
        {
            player.velocity = new Vector2(player.velocity.x, 0f);
            player.AddForce(new Vector2(0, altura), ForceMode2D.Impulse);
            suelo = false;
            anim.SetBool("isJumping", !suelo);
        }
        
        suelo = Physics2D.OverlapCircle(checarsuelo.position, revisarsuelo, capasuelo);
        anim.SetBool("isJumping", !suelo);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Lava") || collision.gameObject.CompareTag("Pico"))
        {
           // gameManager.GameOver();
        } else if (collision.gameObject.CompareTag("Manzana"))
        {
           // Puntuacion.score++;
            Destroy(collision.GetComponent<Collider2D>());
            collision.GetComponent<Animator>().SetBool("recogido", true);
            
        }
    }



}
