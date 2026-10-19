namespace SanskarConnectX.Desktop.ViewModels;

public sealed class BluetoothPairingViewModel : ViewModelBase
{
    public string PairingCode { get; private set; } = "12345678";
    public string Status { get; private set; } = "Waiting for PairDock device";
}

