using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    SpriteRenderer mySpriteRenderer;
    Rigidbody2D rb2d;

    public float speed = 5;

    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {


        //consistient speed in x direction
        Vector3 movement = new Vector3();
        movement.x = speed;
        movement.y = 0;

        rb2d.velocity = new Vector2(movement.x, movement.y);


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


}
