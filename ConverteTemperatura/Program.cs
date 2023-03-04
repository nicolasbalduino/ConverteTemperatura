double celsius, farenheit;

Console.Write("Informe a temperatura em graus celsius: ");
celsius = double.Parse(Console.ReadLine());

farenheit = celsius * 1.8 + 32;

Console.WriteLine("\nA temperatura e " + farenheit + "° Farenheit");
