using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Add this component to a camera and then assign a game object to follow. -P. 20221104

public class cameraFollowGameObject : MonoBehaviour
{
    public GameObject followThisGameObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //add two Vector3s together to create an offset value -P. 20221104
        Vector3 cameraOffset = followThisGameObject.transform.localPosition + new Vector3(0,0,-20);
        // Move the object to the same position as the parent:
        transform.localPosition = cameraOffset;
        // Get the y component of the position relative to the parent
        // and print it to the Console
        print(transform.localPosition.y);
    }
}
