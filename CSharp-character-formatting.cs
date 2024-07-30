using System;

// \t create a tab
Console.WriteLine("Hello\tWorld!");

// \n create a 'end line'
Console.WriteLine("Hello\nWorld!");

// \" create a " in string
Console.WriteLine("Hello\"World!");

// \\ create a \ in string
Console.WriteLine("Hello\\World!");

// @ allows you to use special characters "verbatim string"
Console.WriteLine(@"Hello World! \ | / : ' ");

// \u allows you to use hexacharacters
Console.WriteLine("\u263A");

//pratice
string Name = "Raul";
string Nname = Name + '!';

Console.WriteLine("Hi, my name is " + Nname);

string Apresent = "Hi, my name is ";
int age = 20;

Console.WriteLine($"{Apresent}{Name}! I have {age} Yo");