using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    //public Transform button;

    private Vector3 movement;


    // Start is called before the first frame update
    void Start()
    {
        movement = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x += 2 * Time.deltaTime;

        transform.position = movement;

    }
}
