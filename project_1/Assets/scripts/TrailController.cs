using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(TrailRenderer))]
public class TrailController : MonoBehaviour
{
    public TrailRenderer trailObj;
    // Start is called before the first frame update
    void Start()
    {
        trailObj = GetComponent<TrailRenderer>();
        trailObj.endColor = Color.blue;
        trailObj.startColor = Color.cyan;
        trailObj.startWidth = 1f;
        trailObj.endWidth = 0.1f;
        trailObj.time = 1f;
        trailObj.alignment = LineAlignment.View;
        trailObj.autodestruct = false;
        trailObj.textureMode = LineTextureMode.Stretch;

    }

    // Update is called once per frame
    void Update()
    {
        //ask how to deactivate trail at certain point reached
    }
}
