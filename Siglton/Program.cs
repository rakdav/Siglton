// See https://aka.ms/new-console-template for more information
using Siglton;

Computer computer=new Computer();
computer.Launch("Windows 10");
Console.WriteLine(computer.OS.Name);
computer.OS = OS.getInstance("Linux");
Console.WriteLine(computer.OS.Name);

