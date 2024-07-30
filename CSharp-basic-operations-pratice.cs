using System;

//pratice operations

int firstnumber = 15;

int secondnumber = 5;

string Name = "Raul";

Console.WriteLine("My name is " + Name + ". I have " + (firstnumber + secondnumber) + " yo");

//int operations

Console.WriteLine("int operations");

int sum = firstnumber + secondnumber;

int difference = firstnumber - secondnumber;

int product = firstnumber * secondnumber;

int quotient = firstnumber / secondnumber;

int  remainder = firstnumber % secondnumber;

Console.WriteLine($"sum = {firstnumber} + {secondnumber} = {sum}");

Console.WriteLine($"difference = {firstnumber} - {secondnumber} = {difference}");

Console.WriteLine($"product = {firstnumber} * {secondnumber} = {product}");

Console.WriteLine($"quotient = {firstnumber} / {secondnumber} = {quotient}");

Console.WriteLine($"remainder = {firstnumber} % {secondnumber} = {remainder}");

//decimal operations

decimal dfirstnumber = 15.0m;

decimal dsecondnumber = 5.0m;

Console.WriteLine("decimal operations");

decimal dsum = dfirstnumber + dsecondnumber;

decimal ddifference = dfirstnumber - dsecondnumber;

decimal dproduct = dfirstnumber * dsecondnumber;

decimal dquotient = dfirstnumber / dsecondnumber;

decimal dremainder = dfirstnumber % dsecondnumber;

Console.WriteLine($"sum = {dfirstnumber} + {dsecondnumber} = {dsum}");

Console.WriteLine($"difference = {dfirstnumber} - {dsecondnumber} = {ddifference}");

Console.WriteLine($"product = {dfirstnumber} * {dsecondnumber} = {dproduct}");

Console.WriteLine($"quotient = {dfirstnumber} / {dsecondnumber} = {dquotient}");

Console.WriteLine($"remainder = {dfirstnumber} % {dsecondnumber} = {dremainder}");

//pratice

int fahrenheit = 94;

decimal celsius = (fahrenheit - 32m) * (5m / 9m);

Console.WriteLine("The temperature is " + celsius + " Celsius.");