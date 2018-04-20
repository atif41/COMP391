using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    public int speed = -2;
   



    // Use this for initialization
    void Start()
    {
        
        jets();
       
    }

    // Update is called once per frame
    void Update()
    {
  
            
       
            
     }
    void jets()
    {
    
            transform.position = new Vector2(transform.position.x -2, transform.position.y -1);
            speed = +speed;
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
    

   }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "lborder")
        {
            Destroy(gameObject);
           
        }
    }
    }
