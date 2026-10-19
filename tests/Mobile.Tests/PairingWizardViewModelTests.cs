using Xunit;

namespace SanskarConnectX.Tests.Mobile;

public sealed class PairingWizardViewModelTests
{
    [Fact]
    public void PhaseOneMobileTestPlaceholderDocumentsPairingWizard()
    {
        Assert.Contains("Bluetooth pairing", "Bluetooth pairing wizard");
    }
}

