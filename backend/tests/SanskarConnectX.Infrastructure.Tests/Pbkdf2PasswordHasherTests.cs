using SanskarConnectX.Infrastructure.Security;
using Xunit;

namespace SanskarConnectX.Infrastructure.Tests;

public sealed class Pbkdf2PasswordHasherTests
{
    [Fact]
    public void Hash_UsesUniqueSaltAndVerifiesOnlyCorrectPassword()
    {
        var hasher = new Pbkdf2PasswordHasher();
        var first = hasher.Hash("correct horse battery staple");
        var second = hasher.Hash("correct horse battery staple");

        Assert.StartsWith("pbkdf2-sha256:310000:", first);
        Assert.NotEqual(first, second);
        Assert.True(hasher.Verify("correct horse battery staple", first));
        Assert.False(hasher.Verify("wrong password", first));
    }

    [Theory]
    [InlineData("")]
    [InlineData("scx-sha256:old:hash")]
    [InlineData("pbkdf2-sha256:310000:broken:hash")]
    [InlineData("pbkdf2-sha256:1:AAAAAAAAAAAAAAAAAAAAAA==:AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA=")]
    public void Verify_RejectsInvalidOrUnsupportedHashes(string storedHash)
    {
        Assert.False(new Pbkdf2PasswordHasher().Verify("password", storedHash));
    }
}
