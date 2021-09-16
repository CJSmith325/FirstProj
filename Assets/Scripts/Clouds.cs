using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    public float speed = 1.5f;
    
    
    // Update is called once per frame
    void Update()
    {
        // store current postion value of transform
        // current position of object stored
        Vector3 temp = this.transform.position;
        // add speed to current position value of temp.x
        // time.deltatime bases movement on time and not frame rate
        temp.x = temp.x + speed * Time.deltaTime;
        // use new temp.x to teleport object in small increments
        this.transform.position = temp;


    }
}
