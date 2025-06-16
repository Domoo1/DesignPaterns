namespace free.src.DesignPatterns.Behavioral.State;

public class DraftState : State
{
    private Document _document;
    public DraftState(Document document)
    {
        _document = document;
    }
    public void Publish()
    {
        _document.state = new ModerationState(_document);
    }
}