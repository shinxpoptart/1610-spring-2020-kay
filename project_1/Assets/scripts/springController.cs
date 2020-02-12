using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpringJoint))]
public class springController : MonoBehaviour

{
    public SpringJoint springObj;
    // Start is called before the first frame update
    void Start()
    {
        springObj = GetComponent<SpringJoint>();
        springObj.maxDistance = 1f;
        springObj.minDistance = 1f;
        springObj.anchor = Vector3.one;
        springObj.tolerance = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
