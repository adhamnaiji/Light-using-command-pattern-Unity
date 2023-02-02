using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exemple.Command
public class LightActiveToggle :ICommand
{
    Light _light = null;

    public LightActiveToggle(Light light)
    {
        _light = light;
    }

    public void execute()
    {
        Debug.Log("toggle on/off state");
        _light.enabled = !_light.enabled;
    }

    public void undo()
    {
        Debug.Log("undo: toggle back to other state");
        _light.enabled = !_light.enabled;

    }
}
