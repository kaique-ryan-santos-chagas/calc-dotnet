﻿static void sum(){

    Console.WriteLine("");
    Console.Write("Digite um número: ");
    var numberOne = Console.ReadLine();

    Console.Write("Digite outro número: ");
    var numberTwo = Console.ReadLine();

    var sum = Double.Parse(numberOne) + Double.Parse(numberTwo);

    Console.WriteLine("");
    Console.WriteLine($"{numberOne} + {numberTwo} = {sum}");

}

static void sub(){
    
    Console.WriteLine("");
    Console.Write("Digite um número: ");
    var numberOne = Console.ReadLine();

    Console.Write("Digite outro número: ");
    var numberTwo = Console.ReadLine();

    var sum = Double.Parse(numberOne) - Double.Parse(numberTwo);

    Console.WriteLine("");
    Console.WriteLine($"{numberOne} - {numberTwo} = {sum}");

}


static void multi(){

    Console.WriteLine("");
    Console.Write("Digite um número: ");
    var numberOne = Console.ReadLine();

    Console.Write("Digite outro número: ");
    var numberTwo = Console.ReadLine();

    var sum = Double.Parse(numberOne) * Double.Parse(numberTwo);

    Console.WriteLine("");
    Console.WriteLine($"{numberOne} * {numberTwo} = {sum}");

}


static void div(){
    
    Console.WriteLine("");
    Console.Write("Digite um número: ");
    var numberOne = Console.ReadLine();

    Console.Write("Digite outro número: ");
    var numberTwo = Console.ReadLine();

    var sum = Double.Parse(numberOne) / Double.Parse(numberTwo);

    Console.WriteLine("");
    Console.WriteLine($"{numberOne} / {numberTwo} = {sum}");

}


Console.WriteLine("Calculadora básica");
Console.WriteLine("==================");
Console.WriteLine("");

Console.WriteLine("1 - Soma.");
Console.WriteLine("2 - Subtração.");
Console.WriteLine("3 - Multiplicação.");
Console.WriteLine("4 - DIvisão.");
Console.WriteLine("");

Console.Write("Digite a opção desejada: ");
var option = Console.ReadLine();

switch(option){

    case "1":
        sum();
    break;

    case "2":
        sub();
    break;

    case "3":
        multi();
    break;

    case "4":
        div();
    break;

}
