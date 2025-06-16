namespace free.src.DesignPatterns.Behavioral.State;

public class ModerationState : State
{
    private Document _document;

    public ModerationState(Document document)
    {
        _document = document;
    }
    public void Publish()
    {
        if (_document.role == UserRoles.Admin)
        {
            _document.state = new PublishedState(_document);
        }
    }
}