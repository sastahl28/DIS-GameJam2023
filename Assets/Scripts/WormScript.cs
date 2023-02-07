using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormScript : MonoBehaviour
{
    private Vector3 startPosition;

    public float speed = 5;

    public float delta = 4;

    private float frameTimer = 0;
    private int currentFrame = 0;

    public Sprite[] frames;

    SpriteRenderer sr;
    Rigidbody2D rb2d;
     
    public float offset;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;

        sr = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        float movementY = startPosition.y + Mathf.PingPong(speed * Time.time + offset, delta);

        frameTimer -= Time.deltaTime;

        if (frameTimer <= 0)
        {
            sr.sprite = frames[currentFrame];

            frameTimer = 1 / speed;
            currentFrame++;
            if (currentFrame >= frames.Length)
            {
                currentFrame = 0;
            }

        }

        Vector3 pos = new Vector3(startPosition.x, movementY, startPosition.z);
        transform.position = pos;
    }
}
