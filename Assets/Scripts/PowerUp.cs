using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("LiveUp"))
        {
            gameManager.UpdateLives(+1);
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.CompareTag("ScoreUp"))
        {
            gameManager.UpdateScore(+50);
            Destroy(collision.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
