using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemylaser : MonoBehaviour
{
    public Transform bullet;
    public float speed;


    // Use this for initialization
    void Start()
    {
        bullet = GetComponent<Transform>();
    }
    void FixedUpdate()
    {
        bullet.position += Vector3.right * -speed;
       // if (bullet.position.x == -20)
          //  Destroy(bullet.gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
//            GameOver.IsPlayerDead = true;
        }
        else if (other.tag == "base")
        {
            GameObject playerBase = other.gameObject;
  //          BaseHealth baseHealth = playerBase.GetComponent<BaseHealth>();
    //        baseHealth.health -= 1;
            Destroy(gameObject);
        }
    }
}

