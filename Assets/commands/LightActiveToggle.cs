using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightActiveToggle : ICommand
{
    Light _light;

    public LightActiveToggle(Light light)
    {
        _light = light;
    }

    public void execute()
    {
        Debug.Log("toggle  turn on/off");
        _light.enabled = !_light.enabled;
    }

    public void undo()
    {
        Debug.Log("Undo");
        _light.enabled = !_light.enabled;
    }
}
