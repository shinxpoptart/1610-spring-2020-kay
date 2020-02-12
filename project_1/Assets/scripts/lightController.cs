using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
[RequireComponent((typeof(Light)))]
public class lightController : MonoBehaviour
{
    private Light lightobj;
    // Start is called before the first frame update
    void Start()
    {
        lightobj = GetComponent<Light>();
        lightobj.intensity = 0f;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
