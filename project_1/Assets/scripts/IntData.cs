﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
   public int value = 1;

   public void ChangeValue(int number)
   {
      value += number; 
         //adding value to a float
   }
}

//int data has one data -> value 