namespace free.src.DesignPatterns.Behavioral.Memento;

public class History
{
    private List<EditorState> _states = new List<EditorState>();
    private Editor _editor;

    public History(Editor editor)
    {
        _editor = editor;
    }

    public void BackUp()
    {
        _states.Add(_editor.CreateState());
    }

    public void Undo()
    {
        if (_states.Count == 0)
        {
            return;
        }
        EditorState previousState = _states.Last();
        _states.Remove(previousState);

        _editor.Restore(previousState);
    }

    public void ShowHistory()
    {
        Console.WriteLine("\nHistory: Here is the list of Mementos: ");
        foreach (var state in _states)
        {
            Console.WriteLine(state.GetName());
        }
    }
}