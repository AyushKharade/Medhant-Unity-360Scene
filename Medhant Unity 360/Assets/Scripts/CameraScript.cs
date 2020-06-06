using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// I put this script on the camera already so if you need to work with it, you can just make the changes here.
// a script reference to the camera is saved in camRef down below. Use that directly. Any changes here will apply on the camera object.

// Example of rotating an object on Y axis:
//                              x,  y,  z
// transform.Rotate(new Vector3(0, 15f, 0));

  // if you put this line in Update(), this line will run every frame and the camera will rotate on Y by 15 every frame.


public class CameraScript : MonoBehaviour
{
    Transform camRef;


    // Start is called before the first frame update
    void Start()
    {
        camRef = transform;
    }

    // Update is called once per frame
    void Update()
    {
           
    }
}
