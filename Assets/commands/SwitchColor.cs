using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SwitchColor 
{
public   static Color CreateRandomColor()
    {
        float randomR = UnityEngine.Random.Range(0, 1f);
        float randomB = UnityEngine.Random.Range(0, 1f);
        float randomG = UnityEngine.Random.Range(0, 1f);
        Color newColor = new Color(randomR, randomB, randomB,1);

        return newColor;
    }
}
