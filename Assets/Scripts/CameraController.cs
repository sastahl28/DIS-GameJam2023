using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{

    public Transform button;

    private Vector3 movement;

    public float cameraSpeed = 2;
    public float offset = 0;
    


    // Start is called before the first frame update
    void Start()
    {
        movement = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 buttonPosition = button.transform.position;
        Vector3 cameraPosition = transform.position;

        if(buttonPosition.x + offset >= cameraPosition.x && !Input.GetKey(KeyCode.Space))
        {
            movement.x = buttonPosition.x;
        }
        else
        {
            movement.x += cameraSpeed * Time.deltaTime;
        }

        if(buttonPosition.x < cameraPosition.x - 10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        transform.position = movement;

    }

  
}
