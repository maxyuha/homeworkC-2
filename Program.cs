using System;

namespace ConsoleApp
{
     class Program
     {
        static void Main(string[] args)
        {//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

        void Domashka()
        {
            string number=Console.ReadLine();
            if (number.Length>2)Console.WriteLine(number[2]);
            else Console.WriteLine("в числе меньше 3 символов");
            
            
        }
        Domashka();
     }
    
 }
} 