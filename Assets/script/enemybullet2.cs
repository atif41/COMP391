using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybullet2 : MonoBehaviour
{
    private Transform bullet;
    public float speed;
    public GameObject shot;
    public Transform shotspawn;
    public float firerate;

    private float nextfire;

    // Use this for initialization
    void Start()
    {
        bullet = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Random.value > firerate)
        {
            Instantiate(shot);
        }
    }
    void FixedUpdate()
    {
        bullet.position += Vector3.right * -speed;
        if (bullet.position.y <= -10)
            Destroy(bullet.gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
           
            HealthBarScript.health -= 5f;
           
        }
         if (other.tag == "lborder")
        {
           Destroy(gameObject);
        }
        else if (other.tag == "plat")
        {
            Destroy(gameObject);
        }
    }
}



