using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBound : MonoBehaviour
{
    private float xBound = 7.6f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ConstranPlayerPosition();
    }
    void ConstranPlayerPosition()
    {
        if(transform.position.x<-xBound)
        {
            transform.position = new Vector2(-xBound, transform.position.y);
        }
        else if(transform.position.x>xBound)
        {
            transform.position = new Vector2(xBound, transform.position.y);
        }
    }
}
