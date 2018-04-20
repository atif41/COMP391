using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optilaser : MonoBehaviour
{
    private Transform laser;
    public float speed;
    public GameObject explosion;


    // Use this for initialization
    void Start()
    {
        laser = GetComponent<Transform>();

    }

    void FixedUpdate()
    {
        laser.position += Vector3.right * speed;
          if (laser.position.y >= 10)
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            Destroy(other.gameObject);
            GameObject fire = (GameObject)Instantiate(explosion, other.gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(fire, 1.0f);

        }

    }
}


