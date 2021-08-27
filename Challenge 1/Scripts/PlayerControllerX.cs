using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{ 
    private float speed = 20.0f;
  //  private float rotationSpeed = 25.0f;
    private float verticalInput;
   // private Vector3 newRotation = new Vector3(0, 1,0);
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
      // transform.eulerAngles = newRotation;

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed* Time.deltaTime);

        transform.Rotate(Vector3.left *speed*verticalInput*Time.deltaTime);

       // transform.RotateAround(newRotation, Vector3.up, 90);
        
        // tilt the plane up/down based on up/down arrow keys
                
    }
}
