using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed=500f;

    bool inPlay;

    [SerializeField]
    Transform ballTransformPos;

    GameManager gameManager;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = Object.FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if(gameManager.gameOver)
        {
            return; //E�er Update i�inde 'return' fonksiyonu kullan�l�rsa a�a��daki sat�rlar okunmaz ve direk oyun orada kal�r.
            //Di�er scripten ald���m�z 'gameOver' fonksiyonu 'true' ise oyun sonu erer.
        }

        if (!inPlay)
        {
            transform.position = ballTransformPos.position;
        }



        if (Input.GetButtonDown("Jump") && !inPlay)
        {
            rb.AddForce(Vector2.up * speed);
            inPlay = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bottom"))
        {
            rb.velocity = Vector2.zero;
            inPlay = false;
            gameManager.UpdateLives(-1);

        }

    }
}
