// See https://aka.ms/new-console-template for more information


using _3._1;

ITeslaModel3 car = new LongRangeTeslaDecorator(component: new RedPaintTeslaDecorator(car: new BasicTeslaModel3()));

Console.WriteLine($"Description: {car.GetDescription()}");
Console.WriteLine($"Price: {car.GetPrice()}");
Console.WriteLine($"Range: {car.GetRange()}");
