using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public bool Checkpointreached;
    public Sprite checkpoint1;
    public Sprite checkpoint2;
    private SpriteRenderer CheckPointSpritRerenderer;



    // Use this for initialization
    void Start()
    {
        CheckPointSpritRerenderer = GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            CheckPointSpritRerenderer.sprite = checkpoint2;
            Checkpointreached = true;
        }
    }
}
