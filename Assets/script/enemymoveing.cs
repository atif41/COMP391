using UnityEngine;
using System.Collections;

public class enemymoveing : MonoBehaviour
{

    private bool dirup = false;
    public float speed = 2.0f;

    void Update()
    {
        if (dirup)
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.down * speed * Time.deltaTime);

        if (transform.position.y >= 1.89)
        {
            dirup = false;
        }

        if (transform.position.y <= -0.13)
        {
            dirup = true;
        }
    }
}