public abstract class Participant
{
    private string id;

    protected Participant(string id)
    {
        this.id = id;
    }

    public string Id => id;

    public abstract string GetTypeName();
}

