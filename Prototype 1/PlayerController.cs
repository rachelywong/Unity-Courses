using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables
    private float speed = 20;
    private float turnSpeed = 70;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Grant player left/right movement input
        horizontalInput = Input.GetAxis("Horizontal"); // Name of Horizontal axis is "Horizontal"

        // Grant player access to vehicle speed
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Move the vehicle left and right
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        // Make vehicle turn
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput); // up is y-axis and then , angle
    }
}
