namespace BucketListServer;

public class Goal
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Category Category { get; set; }
    // TODO: придумать нормальное имя 
    public List<Todo> Todoes { get; set; }
    public Privacy Privacy { get; set; }

    public bool IsCompleted => Todoes.All(t => t.IsCompleted);
    public float Progress => (float)Todoes.Count(t => t.IsCompleted) / Todoes.Count;
}