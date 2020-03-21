using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    private const string V = "2.49";
    public float speed = 5f;
    public float jumpspeed = 8f;
    private float movement = 0f;

    private Rigidbody2D rigidBody;
    public Transform groundcheckpoint;
    public float groundcheckradius;
    public LayerMask groundlayer;
    private bool isTouchingGround;
    private Animator playeranimation;
    public Vector3 respawnPoint;
    public LevelManager gameLevelManager;


    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        playeranimation = GetComponent<Animator>();
        respawnPoint = transform.position;
        gameLevelManager = FindObjectOfType<LevelManager>();


    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundcheckpoint.position, groundcheckradius, groundlayer);
        movement = Input.GetAxis("Horizontal");

        if (movement > 0f)
        {
            rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
            transform.localScale = new Vector2(2.49f, 1f);
        }
        else if (movement < 0f)
        {

            rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
            transform.localScale = new Vector2(-2.49f, 1f);

        }
        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpspeed);
        }
        playeranimation.SetFloat("speed", Mathf.Abs(rigidBody.velocity.x));
        playeranimation.SetBool("onground", isTouchingGround);

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Falldetector")
        {
            gameLevelManager.Respawn();


        }
        if (other.tag == "Checkpoint")
        {
            respawnPoint = other.transform.position;

        }
        if (other.tag == "Bomb")
        {
            Destroy(gameObject);
        }
    }


}
