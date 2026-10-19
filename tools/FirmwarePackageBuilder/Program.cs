using SanskarConnectX.Tools.FirmwarePackageBuilder;

var version = args.Length > 0 ? args[0] : "0.1.0";
var manifest = new PackageManifest(version, "rev-a", "phase1-hash-placeholder", "phase1-signature-placeholder");

Console.WriteLine("PairDock Firmware Package Builder");
Console.WriteLine("Made by Sanskar");
Console.WriteLine(manifest);

