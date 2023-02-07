using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legos : MonoBehaviour
{
    

    public GameObject lego;
    public int legoTimer;
    private bool hit;
  

    

    void Start()
    {
        hit = false;
    }

    // Update is called once per frame
    void Update()
    {
        legoTimer -= 1;
        if (hit && legoTimer < 0)
        {
            Destroy(lego);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            hit = true;
        }
    }
}
