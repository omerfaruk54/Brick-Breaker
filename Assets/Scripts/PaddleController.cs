using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    private float speed=10f;

    GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePaddle();
    }

    void MovePaddle()
    {
        if(gameManager.gameOver)
        {
            return;
        }
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right *  horizontalInput *  speed * Time.deltaTime);
    }
}
