using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    SpriteRenderer mySpriteRenderer;
    Rigidbody2D rb2d;

    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        


        //consistient speed in x direction
        Vector3 movement = new Vector3();
        movement.x = speed;
        movement.y = 0;

        rb2d.velocity = new Vector2(movement.x, movement.y);


    }
}
