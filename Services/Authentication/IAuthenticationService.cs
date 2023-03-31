namespace BucketListServer.Services;

public interface IAuthenticationService
{
    bool Validate(string name, string password);

    void Login();

    void LoginGoogle();

    void Logout();
}