namespace SanskarConnectX.Mobile.ViewModels;

public sealed class PairingWizardViewModel : MobileViewModelBase
{
    public int CurrentStep { get; private set; } = 1;
    public string PairingStatus { get; private set; } = "Scanning for PairDock devices";

    public void NextStep()
    {
        CurrentStep++;
        OnPropertyChanged(nameof(CurrentStep));
    }
}

