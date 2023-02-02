using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandStack 
{
    private Stack<ICommand> _commandHistory = new Stack<ICommand>();

   public void ExecuteCommand(ICommand command)
    {
        command.execute();
        _commandHistory.Push(command);
    }

    public void UndoLastCommand()
    {
        if (_commandHistory.Count <= 0)
            return;
        _commandHistory.Pop().undo();
    }
}
