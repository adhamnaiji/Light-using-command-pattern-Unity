
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField] Light _light = null;

    [Header("inputs")]
    [SerializeField] KeyCode _toggleKey = KeyCode.Alpha1;
    [SerializeField] KeyCode _change = KeyCode.Alpha3;
    [SerializeField] KeyCode _undoo = KeyCode.Z;


    CommandStack _commandStack = new CommandStack();



    // Update is called once per frame
    void Update()
    {
        DetectToggleInput();
        DetectRandomColor();
        UndoLastColorr();
    }

    private void UndoLastColorr()
    {
        if (Input.GetKeyDown(_undoo))
        {
            _commandStack.UndoLastCommand();
        }
    }

    private void DetectRandomColor()
    {
        if (Input.GetKeyDown(_change))
        {
            _commandStack.ExecuteCommand(new LightColorChange(_light,SwitchColor.CreateRandomColor()));
        }
    }

    private void DetectToggleInput()
    {
        if (Input.GetKeyDown(_toggleKey))
        {
            _commandStack.ExecuteCommand(new LightActiveToggle(_light));
        }
    }
}
