Console.WriteLine("PairDock Telemetry Generator");
Console.WriteLine("deviceId,timestampUtc,rssi,temperatureCelsius,supplyMillivolts");

for (var i = 0; i < 10; i++)
{
    Console.WriteLine($"SCX-SIM-001,{DateTimeOffset.UtcNow.AddSeconds(i):O},{-50 - i},{27 + i % 2},3300");
}

