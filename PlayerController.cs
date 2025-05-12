using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables
    private float speed = 5.0f; // set vehicle speed
    private float turnSpeed = 20f; // how much it strafes left (-) or right (+)
    private float horizontalInput; // the key used to move horizontally
    private float forwardInput; // the key used to move vertically

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        // transform.Translate(0, 0, 1);

        // input gathering
        horizontalInput = Input.GetAxis("Horizontal"); // assigning the horizontal axis (right and left arrow)
        forwardInput = Input.GetAxis("Vertical"); // assigning the vertical axis (up and down arrow)

        // vehicle movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); // move the car forward
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput); // move left (-) or right (+)
    }
}
