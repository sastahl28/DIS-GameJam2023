using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    
    

    private Rigidbody2D rb2d;
    private SpriteRenderer sRenderer;

    public Sprite water;

    public WaterFountain waterFountain;

    

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sRenderer = GetComponent<SpriteRenderer>();
        
        
    }

    // Update is called once per frame
    void Update()
    {


     Vector2 orgin = transform.position;


         
            Vector2 leftDirection = new Vector2(-3, 0);
        
            RaycastHit2D hitLeft = Physics2D.Raycast(orgin, leftDirection, leftDirection.magnitude);


        if (hitLeft.collider != null && hitLeft.collider.CompareTag("Button"))
        {
            Instantiate(waterFountain, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }



    
   

    }
}
