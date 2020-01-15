using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewClass : MonoBehaviour
{
    // Start is called before the first frame update
    
    public string NameString;
    public int intNum;
    public float floatNum;
    public GameObject gameObj;

    private void Start()
    {
        print( NameString);
        print(intNum);
        print(floatNum);
        print(gameObject);
        
    }
}
