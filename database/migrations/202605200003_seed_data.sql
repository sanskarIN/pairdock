BEGIN;

INSERT INTO Users (Id, Email, DisplayName, PasswordHash, Role)
VALUES
  ('00000000-0000-0000-0000-000000000001', 'admin@sanskarconnectx.local', 'PairDock Admin', 'phase1-seed-hash', 'Admin')
ON CONFLICT (Email) DO NOTHING;

INSERT INTO Devices (Id, DeviceId, SerialNumber, DisplayName, FirmwareVersion, HardwareRevision, ConnectionState)
VALUES
  ('00000000-0000-0000-0000-000000000101', 'SCX-DEVKIT-001', 'SCX-2026-0001-000001', 'Lab DevKit', '0.1.0', 'rev-a', 'Online')
ON CONFLICT (DeviceId) DO NOTHING;

COMMIT;
