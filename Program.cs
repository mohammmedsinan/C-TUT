using System;

namespace CTUT 
{
class Program   
{
    static void Main(String[] args) 
    {
        /***********************************************/
        //[ dec + init ]
        int X; //declaration
        X = 9; //initialization
        int Y = 9; // declaration + initialization
        /***********************************************/
        //[ variables types ]
        int age = 10; //whole integer
        double height = 120.34; //decimal Number
        bool alive = true; //two values true , false
        char symbol = '@'; //takes just one character
        string name = "Mohammed"; //it takes name value
        float atom = 12.444f; //float takes more than 2 numbers after the dot

        Console.WriteLine($"this is x value {X} , and this is y value {Y}");
        Console.ReadKey();
    }
}    
}