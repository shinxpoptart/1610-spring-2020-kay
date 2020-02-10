using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

    public int a = 10;
    public int b = 4;
    public int c = 14;
    public string password = "OU812";
    public bool canRun = true;
    
    // Start is called before the first frame update
    void Start()
    {
        if (a + b != c)
        {
            print("that's true my guy");
        }

        if (password == "OU812")
        {
            print("that is the right password");
        }

        if (!canRun)
        {
            print("we can't run");
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
