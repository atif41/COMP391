using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybullet: MonoBehaviour
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
        bullet.position += Vector3.down * -speed;
        if (bullet.position.y <= -10)
            Destroy(bullet.gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "player")
        {
         HealthBarScript.health -= 5f;
        }
        else if (other.tag == "ground")
        {
          Destroy(gameObject);
        }
        else if ( other.tag =="plat")
        {
            Destroy(gameObject);
        }
        else if (other.tag == "dead")
        {
            Destroy(gameObject);
        }
        else if (other.tag == "shelter")
        {
            GameObject playerBase = other.gameObject;
            shealter Health = playerBase.GetComponent<shealter>();
            Health.health -= 1;
            Destroy(gameObject);
        }
    }
}


