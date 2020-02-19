using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{

    public float value = 1f;

    public void Changevalue(float number)
    {
        value += number;
    }

}
