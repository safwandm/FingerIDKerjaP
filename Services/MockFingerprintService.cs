namespace FingerID.Services;

public class MockFingerprintService : IFingerprintService
{
    public bool VerifyFingerprint(string username)
    {
        return true;
    }
}
