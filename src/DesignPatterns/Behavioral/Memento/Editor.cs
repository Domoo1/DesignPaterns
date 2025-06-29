namespace free.src.DesignPatterns.Behavioral.Memento;

// Originator
public class Editor
{
    public string Title { get; set; }
    public string Content { get; set; }

    public EditorState CreateState()
    {
        return new EditorState(Title, Content);
    }

    public void Restore(EditorState editorState)
    {
        Title = editorState.GetTitle();
        Content = editorState.GetContent();
    }
}

    