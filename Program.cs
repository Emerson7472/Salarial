Decimal sueldomensual = 0.0m;
Decimal sueldoanual = 0.0m;
Decimal ISR = 0.0m;
Console.WriteLine("----SUELDO MENSUAL Y ANUAL Y ISR----");
Console.WriteLine();
Console.WriteLine("INGRESE EL SUELDO MENSUAL");
Console.WriteLine();
sueldomensual = Convert.ToDecimal(Console.ReadLine());
sueldoanual = sueldomensual * 12;
Console.WriteLine();
Console.WriteLine($"EL SUELDO MENSUAL ES: {sueldomensual}");
Console.WriteLine();
Console.WriteLine($"EL SUELDO ANUAL ES: {sueldoanual}");
Console.WriteLine();
if (sueldoanual <= 416220.00m){ISR = 0.0m;}
else if (sueldoanual <= 624329.00m){ISR = (sueldoanual - 416220.00m) * 0.15m;}
else if (sueldoanual <= 867123.00m){ISR = 31216.00m + ((sueldoanual - 624329.00m) * 0.20m);}
else{ISR = 79776.00m + ((sueldoanual - 867123.00m) * 0.25m);}
Console.WriteLine($"EL IMPUESTO SOBRE LA RENTA (ISR) ES: {ISR}");