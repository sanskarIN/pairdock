using SanskarConnectX.Desktop.ViewModels;
using Xunit;

namespace SanskarConnectX.Tests.Desktop;

public sealed class WifiSetupViewModelTests
{
    [Fact]
    public void StartProvisioningSetsBusyState()
    {
        var vm = new WifiSetupViewModel();
        vm.StartProvisioning();
        Assert.True(vm.IsProvisioning);
    }
}
