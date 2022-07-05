using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.01f;
    private Touch touch;
 
    void Update ()
    {
        touch = Input.GetTouch(0);
        
        if(Input.touchCount > 0 && touch.phase == TouchPhase.Moved )
        {
            transform.position = new Vector3(
            transform.position.x + touch.deltaPosition.x * speed,
            transform.position.y,
            transform.position.z + touch.deltaPosition.y * speed
            );
        }
    }
}
