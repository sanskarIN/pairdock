-- Development seed data for PairDock.

INSERT INTO FirmwareVersions (Id, Version, HardwareRevision, PackageUrl, Sha256, Signature, IsActive)
VALUES (
  '00000000-0000-0000-0000-000000000201',
  '0.1.0',
  'rev-a',
  'https://firmware.local/scx/0.1.0.bin',
  '0000000000000000000000000000000000000000000000000000000000000000',
  'phase1-development-signature',
  TRUE
)
ON CONFLICT (Version, HardwareRevision) DO NOTHING;

