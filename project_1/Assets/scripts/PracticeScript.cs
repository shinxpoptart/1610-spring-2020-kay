using UnityEngine;
using UnityEngine.Events;

public class PracticeScript : MonoBehaviour
{ 
    private float HealthValue;
    public int HealthScore;
    public UnityEvent uEvent;

    // Start is called before the first frame update
    void Start()
    {
        uEvent.Invoke();
        //invoke means call

   print(HealthValue);
   print(HealthScore);
   print("holy macaroni!!");
}

    // Update is called once per frame
    void Update()
    {

    }
}
