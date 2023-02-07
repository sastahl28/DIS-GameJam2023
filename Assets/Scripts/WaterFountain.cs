using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFountain : MonoBehaviour
{
    public float animationfps;
    //private float timer = 10;

    public Button button;
    public Sprite[] wfAnimation;

    private Rigidbody2D rb2d;
    private SpriteRenderer sRenderer;

    public GameObject fountain;


    private float frameTimer;
    //private int frameIndex;
    private int frame = 0;

    public float lifetime;


    // Start is called before the first frame update
    void Start()
    {
        //button = GetComponent<Button>();
        rb2d = GetComponent<Rigidbody2D>();
        sRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {



        frameTimer -= Time.deltaTime;
        lifetime -= Time.deltaTime;
        if (frameTimer <= 0)
        {
            frame += 1;

            if (frame == wfAnimation.Length-1)
            {
                frame = 0;
            }

            frameTimer = (1f / animationfps);
            sRenderer.sprite = wfAnimation[frame];
        }
        if (lifetime < 0)
        {
            
            Destroy(gameObject);
        }




        
    }
}
