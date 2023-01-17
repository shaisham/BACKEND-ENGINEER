﻿using System;
namespace AppInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");


            PasswordManager pm = new PasswordManager("iluvpie", false);

            tdl.Display();
            pm.Display();

            tdl.Reset();
            pm.Reset();

            tdl.Display();
            pm.Display();
            Console.ReadLine();
        }
    }
}