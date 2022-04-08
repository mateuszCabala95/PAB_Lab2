namespace WebApplication1.Entity;

public struct User
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; }
}