using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

[CreateAssetMenu]

public class FloatData : ScriptableObject //scriptable objects stay
{

    public float value = 1f;

    public void ChangeValue(float number)
    {
        value += number;
    }

}

//very important code