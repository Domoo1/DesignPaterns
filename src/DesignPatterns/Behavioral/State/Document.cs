namespace free.src.DesignPatterns.Behavioral.State;

public class Document
{
    public State state { get; set; }
    public UserRoles role { get; set; }

    public Document(UserRoles Role)
    {
        state = new DraftState(this);
        role = Role;
    }

    public void Publish() {
        state.Publish();
    }
}