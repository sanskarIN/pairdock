using SanskarConnectX.Desktop.ViewModels;
using Xunit;

namespace SanskarConnectX.Tests.Desktop;

public sealed class ShellViewModelTests
{
    [Fact]
    public void FooterContainsCredit()
    {
        var vm = new ShellViewModel();
        Assert.Contains("Made by Sanskar", vm.FooterText);
    }
}

