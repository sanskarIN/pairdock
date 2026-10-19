BEGIN;

CREATE INDEX IF NOT EXISTS IX_Telemetry_Device_Timestamp ON Telemetry(DeviceId, TimestampUtc DESC);
CREATE INDEX IF NOT EXISTS IX_DeviceCommands_Device_Status ON DeviceCommands(DeviceId, Status);
CREATE INDEX IF NOT EXISTS IX_AuditLogs_CreatedUtc ON AuditLogs(CreatedUtc DESC);
CREATE INDEX IF NOT EXISTS IX_Notifications_User_Read ON Notifications(UserId, IsRead);
CREATE INDEX IF NOT EXISTS IX_ApiKeys_User ON ApiKeys(UserId);

COMMIT;

