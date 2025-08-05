
namespace Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }

    public User(Guid id, string name, string email)
    {
        Id = id;
        Validate(name, email);
        Name = name;
        Email = email;
    }

    public void AddUser(string name, string email)
    {
        Id = Guid.NewGuid();
        Validate(name, email);
        Name = name;
        Email = email;
    }

    private static void Validate(string name, string email)
    {
        if(name is null || (name.Length < 3))
        {
            throw new Exception("Invalid name");
        }

        if(email is null || !email.Contains("@"))
        {
            throw new Exception("Invalid email");
        }
    }
}
