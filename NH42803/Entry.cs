namespace NH42803;

public class Entry
{
    public virtual Guid Id { get; set; }

    public virtual Update Update { get; set; }

    public virtual int Target { get; set; }
}