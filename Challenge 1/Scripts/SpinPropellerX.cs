using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    float rotateSpeed = 50.0f;
    float degreesPerSecond = 20;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {

        transform.Rotate(new Vector3(0, 0, degreesPerSecond) * Time.deltaTime*rotateSpeed);
        
    }
}
