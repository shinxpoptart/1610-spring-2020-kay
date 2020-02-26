using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class ImageBehavior : MonoBehaviour
{
    private Image imageObj;

    public FloatData dataObj;
    
    // Start is called before the first frame update
    private void Start()
    {
        imageObj = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        imageObj.fillAmount = dataObj.value;
    }
}

//when player collides with killer make health bar go down 
