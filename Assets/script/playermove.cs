using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermove : MonoBehaviour
{
    public Text win;
    public Text gameover;
    public Image abot;
    public Image decepti;
    public GameObject explosion;
    private Transform player;
    public float speed = 6;
    public float jump;
    float moveVelocuty;
    bool grounded = false;
    //  public float maxbound, minbound;

    public GameObject jet;
    public GameObject shot;
    public Transform shotspawn;
    public float firerate;

    private float nextfire;

    // Use this for initialization
    void Start()
    {
        player = GetComponent<Transform>();
        Instantiate(jet);
        gameover.enabled = false;
        decepti.enabled = false;
        win.enabled = false;
        abot.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Check Input Axes
        float h = Input.GetAxisRaw("Horizontal");
        

        player.position += Vector3.right * h * speed;

        // Set Animation Parameters
        GetComponent<Animator>().SetInteger("right", (int)h);


    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextfire)
        {
            nextfire = Time.time + firerate;
            Instantiate(shot, shotspawn.position, shotspawn.rotation);

        }
        //jump
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        { if (grounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
            }
        }
        if (HealthBarScript.health == 0f)
        {
            gameover.enabled = true;
            decepti.enabled = true;
            Destroy(gameObject);
            GameObject fire = (GameObject)Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
            Time.timeScale = 0.0f;
        }
    }
     void OnTriggerEnter2D()
    {
        grounded = true;   
    }
     void OnTriggerExit2D()
    {
        grounded = false;
    }
    private class vector3
    {
        private float x;
        private float jump;

        public vector3(float x, float jump)
        {
            this.x = x;
            this.jump = jump;
        }
    }
}