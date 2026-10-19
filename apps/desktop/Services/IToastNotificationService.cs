namespace SanskarConnectX.Desktop.Services;

public interface IToastNotificationService
{
    void ShowInfo(string message);
    void ShowError(string message);
}
