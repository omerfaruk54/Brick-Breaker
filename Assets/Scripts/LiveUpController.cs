using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveUpController : MonoBehaviour
{
    float speed =3;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
