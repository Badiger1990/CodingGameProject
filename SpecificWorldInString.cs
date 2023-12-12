// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       string EntString = "Hello Mono World";

string StringToRev = EntString.Substring(10);

Console.WriteLine("String to reverse:" + StringToRev);

int Length = StringToRev.Length -1;

string temp="";

while(Length >= 0)
{
    temp = temp +  StringToRev[Length];
    Length--;
}
        
Console.WriteLine("Reversed string:" + temp);
    }
}
