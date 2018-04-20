using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    public float timeBetweenShots;
    public float nextShot = -1;
    public GameObject bullet;
   

    // Use this for initialization
    void Start()
    {
        nextShot = Random.Range(1, 3.0f);
        timeBetweenShots = Random.Range(3, 6.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextShot)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextShot = Time.time + timeBetweenShots;
        }

    }
}