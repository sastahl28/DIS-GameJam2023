using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    SpriteRenderer sr;
    Rigidbody2D rb2d;

    public float speed = 5;

    private Vector3 movement = new Vector3(0.0f, 0.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if(Input.GetKey(KeyCode.Space))
        {
            StopButton();
        }

    }

    public void Move()
    {
        //consistient speed in x direction
        movement.x = speed;

        rb2d.velocity = new Vector2(movement.x, movement.y);
    }

    public void StopButton()
    {
        movement.x = 0;

        rb2d.velocity = new Vector2(movement.x, movement.y);
    }


}
