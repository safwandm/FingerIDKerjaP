namespace FingerID.Services;

public interface IAuthService
{
    bool ValidateCredentials(string username, string password);
}
