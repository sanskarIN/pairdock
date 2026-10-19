using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SanskarConnectX.Mobile.ViewModels;

public abstract class MobileViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
