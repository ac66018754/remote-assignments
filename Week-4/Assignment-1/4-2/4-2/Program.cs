using _4_2;
using Microsoft.Extensions.DependencyInjection;

//注入simple
var services = new ServiceCollection()
    .AddTransient<ICalculator, SimpleCalculator>()
    .BuildServiceProvider();

var calculatorController = new CalculatorController(services.GetService<ICalculator>(), "Add");
Console.WriteLine(calculatorController.Calculate(5, 3));
calculatorController = new CalculatorController(services.GetService<ICalculator>(), "Subtract");
Console.WriteLine(calculatorController.Calculate(5, 3));

//注入advance
var services2 = new ServiceCollection()
    .AddTransient<ICalculator, AdvancedCalculator>()
    .BuildServiceProvider();

var calculatorController2 = new CalculatorController(services2.GetService<ICalculator>(), "Add");
Console.WriteLine(calculatorController2.Calculate(5, 3));
calculatorController2 = new CalculatorController(services2.GetService<ICalculator>(), "Subtract");
Console.WriteLine(calculatorController2.Calculate(5, 3));


Console.ReadLine();