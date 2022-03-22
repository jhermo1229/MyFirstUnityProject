using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{

    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Moves the vehicle forward based on input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        //Rotates vehicle based on input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
