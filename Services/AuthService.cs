namespace FingerID.Services;

public class AuthService : IAuthService
{
    public bool ValidateCredentials(string username, string password)
    {
        // MOCK logic
        return username == "admin" && password == "admin";
    }
}
