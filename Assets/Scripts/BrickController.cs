using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    [SerializeField]
    GameObject brickEffect;

    GameObject clone;
    GameManager gameManager;

    [SerializeField]
    GameObject liveUpPrefab;

    GameObject cloneLiveUp;
    BrickBrokenController brickBrokenController;



    

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        brickBrokenController = GetComponent<BrickBrokenController>();

    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            clone = Instantiate(brickEffect, transform.position, transform.rotation);
            gameManager.UpdateScore(5);

            Destroy(gameObject);
            Destroy(clone, 1.5f);

            brickBrokenController.brickLeft--;

            




            int randomChance = Random.Range(1, 101);
            Debug.Log(randomChance);

            if (randomChance > 70) //Eðer oluþturulan sayý 70'den büyük ise can artýrma prefabýný oluþtur.
            {
                cloneLiveUp = Instantiate(liveUpPrefab, transform.position, transform.rotation);
                Destroy(cloneLiveUp, 10f);
            }
        }

        
    }
}
