using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBrokenController : MonoBehaviour
{
    [SerializeField]
    private Sprite brokenImage;
    int health = 2;

    GameObject clone;
    GameObject cloneScoreUp;

    [SerializeField]
    GameObject brickEffect;

    GameManager gameManager;

    [SerializeField]
    GameObject scoreUpPrefab;


    [SerializeField]
    GameObject[] bricks;

    public int brickLeft;


    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();

        bricks = GameObject.FindGameObjectsWithTag("Brick2");
        brickLeft = bricks.Length;
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {

       
        if (collision.gameObject.CompareTag("Ball"))
        {
            health--;

            Debug.Log("Tuðla Sayýsý: " + brickLeft);


            if (health==1)
            {
                GetComponent<SpriteRenderer>().sprite = brokenImage;
            }
            else if (health==0)
            {
                gameManager.UpdateScore(15);

                Destroy(gameObject);
                clone = Instantiate(brickEffect, transform.position, transform.rotation);
                Destroy(clone, 1.5f);
                brickLeft--;





                int randomChange = Random.Range(1, 101);
                Debug.Log("Turuncu: "+ randomChange);

                if (randomChange>=80)
                {
                    cloneScoreUp= Instantiate(scoreUpPrefab, transform.position, transform.rotation);
                    Destroy(cloneScoreUp, 10f);
                }

            }
        }

           
        
    }
}
