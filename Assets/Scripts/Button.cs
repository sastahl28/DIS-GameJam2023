using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    SpriteRenderer mySpriteRenderer;
    Rigidbody2D rb2d;

    public float speed = 5;
    

    private Vector3 movement = new Vector3(0.0f, 0.0f, 0.0f);
    internal object position;
    private AudioSource death;

    void Start()
    {
        
        rb2d = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        death = GetComponent<AudioSource>();
    }

    
    void Update()
    {

        Move();
        StopButton();
       
        

    }

    public void Move()
    {
        movement.x = speed;
        rb2d.velocity = new Vector2(movement.x, movement.y);
    }

    public void StopButton()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            movement.x = 0.0f;
            rb2d.velocity = new Vector2(movement.x, movement.y);
        }

        if (Input.GetKey(KeyCode.Q))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            death.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (collision.gameObject.CompareTag("NextLevel"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }






}
