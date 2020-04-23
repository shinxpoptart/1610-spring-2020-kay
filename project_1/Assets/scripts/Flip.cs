using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour

{
    public KeyCode key1 = KeyCode.LeftArrow, key2 = KeyCode.RightArrow;
    public float direction1 = 0, direction2 = 180;
    private Vector3 direction;
   
    void Update()
    {
        if (Input.GetKeyDown(key1))
        {
            transform.rotation = Quaternion.Euler(x: 0, y: direction1, z: 0);
        }
        
        if (Input.GetKeyDown(key2))
        {
            transform.rotation = Quaternion.Euler(x: 0, y: direction2, z: 0);
        }
    }

    public void FlipTransform (float value)
    {
        transform.Rotate(xAngle: 0, yAngle: value, zAngle: 0);
    }

}
