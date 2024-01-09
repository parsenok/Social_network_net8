using DB;
public interface IUserService
{
    bool UserExists(string login, string password);
}
public class UserService : IUserService
{
    private readonly YourDbContext dbContext;

    public UserService(YourDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public bool UserExists(string login, string password)
    {
        return dbContext.Users.Any(User => User.Login == login && User.Password == password);
    }
}