// See https://aka.ms/new-console-template for more information
using static System.Console;
using CalculatorPolishNotation;

while (true) {
    Write("Введите выражение: ");
    WriteLine(RPN.Calculate(ReadLine()));
}


