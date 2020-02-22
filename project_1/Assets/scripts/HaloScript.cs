using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(ParticleSystem))]

public class HaloScript : MonoBehaviour

{
    public ParticleSystem particalObj;
    
    // Start is called before the first frame update
    void Start()
    {
        particalObj = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
