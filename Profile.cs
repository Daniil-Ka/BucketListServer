namespace BucketListServer;

public class Profile
{
    public int Id { get; private set; }
    public string Name { set; get; }
    public Uri Photo { get; set; }
    public List<Goal> Goals;
}