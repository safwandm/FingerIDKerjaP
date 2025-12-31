namespace FingerID.Services;

public interface IFingerprintService
{
    bool VerifyFingerprint(string username);
}
