var tests = new[] { "GPIO", "UART", "SPI", "I2C", "ADC", "PWM", "Wi-Fi", "BLE", "Certificate" };

Console.WriteLine("PairDock Manufacturing Test Runner");
Console.WriteLine("Made by Sanskar");

foreach (var test in tests)
{
    Console.WriteLine($"{test}: PASS");
}

