using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColorChange :ICommand
{
    Light _light;
    Color _originalColor;
    Color _newColor;

    public LightColorChange(Light light,Color newColor)
    {
        _light = light;
        _originalColor = light.color;
        _newColor = newColor;
    }

    public void execute()
    {
        Debug.Log("assigned new color");
        _light.color = _newColor;
    }

    public void undo()
    {
        Debug.Log("undo assigned ");
        _light.color = _newColor;
    }
}
