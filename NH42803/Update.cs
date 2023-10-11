namespace NH42803;

public class Update
{
    public virtual Guid Id { get; set; }

    public virtual ICollection<Entry> Entries { get; set; }

    public virtual DateTime Date { get; set; }
}