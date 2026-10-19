-- Phase 1 retention concept. Adapt to production retention policy.

CREATE OR REPLACE FUNCTION DeleteOldTelemetry(retain_days INT)
RETURNS INT AS $$
DECLARE
  deleted_count INT;
BEGIN
  DELETE FROM Telemetry
  WHERE TimestampUtc < NOW() - (retain_days || ' days')::interval;

  GET DIAGNOSTICS deleted_count = ROW_COUNT;
  RETURN deleted_count;
END;
$$ LANGUAGE plpgsql;
