using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foot : MonoBehaviour
{
    public float lifetime = 2;
    public float speed = 3;
    public float distance = 4;

    Vector3 start = new Vector3();
    Vector3 end = new Vector3();
    // which point are we moving to 
    Vector3 target = new Vector3();



    // Start is called before the first frame update
    void Start()
    {

        start = transform.position;
        end = start;
        end.y -= distance;
        target = end; 

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target - transform.position;
        direction.Normalize();
        transform.position = transform.position + direction * speed * Time.deltaTime;

        // if the distance is less than what it would take to get there on the next update
        float distanceTo = (target - transform.position).magnitude;
        float movementDistance = (direction * speed * Time.deltaTime).magnitude;
        if (distanceTo <= movementDistance)
        {
            if (target == start)
            {
                target = end;
            }
            else if(target == end)
            {
                target = start; 
            }
        }
    }

    private void OnDrawGizmos()
    {
        Debug.DrawLine(transform.position, transform.position + new Vector3(0, -distance, 0));
    }

}
