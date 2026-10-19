BEGIN;

CREATE INDEX IF NOT EXISTS IX_Devices_State_LastSeen ON Devices(ConnectionState, LastSeenUtc DESC);
CREATE INDEX IF NOT EXISTS IX_FirmwareVersions_Active_Hardware ON FirmwareVersions(IsActive, HardwareRevision);
CREATE INDEX IF NOT EXISTS IX_DeviceCertificates_Device_Revoked ON DeviceCertificates(DeviceId, RevokedUtc);
CREATE INDEX IF NOT EXISTS IX_Telemetry_CreatedUtc ON Telemetry(CreatedUtc DESC);

COMMIT;
