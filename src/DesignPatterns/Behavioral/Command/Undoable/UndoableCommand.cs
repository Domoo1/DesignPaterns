namespace free.src.DesignPatterns.Behavioral.Command.Undoable;

public interface UndoableCommand : Command
{
    void Unexecute();
}