using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;


public class Explosion : MonoBehaviour
{
    private Animator bomb;
    public bool touched = false;
    public Playercontroller gamePlayer;
    public Text gameOver;
    public LevelManager gameLevelManager;


    // Use this for initialization
    void Start()
    {
        bomb = GetComponent<Animator>();
        gamePlayer = FindObjectOfType<Playercontroller>();

    }

    // Update is called once per frame
    void Update()
    {
        bomb.SetBool("touched", touched);
 
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "player")
        {
            touched = true;
        }
    }
}
