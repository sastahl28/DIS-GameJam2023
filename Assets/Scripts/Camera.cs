using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public Transform button;
    public float offsetX=6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (-1 * (button.position.x) < offsetX)
        {

            pos.x = button.position.x + offsetX;

        }

        transform.position = pos;
    }
}
