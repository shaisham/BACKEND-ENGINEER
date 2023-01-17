using System;

namespace AppInterface
{
    class TodoList : IDisplayable, IResetable
    {
        public string[] Todos
        { get; private set; }

        public string headerSymbol = "-------";
        public string HeaderSymbol
        {
            get
            {
                return headerSymbol;
            }
        }

        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }
        //Define a method that: satisfies the interface requirements
        // uses Console.WriteLine() to write each to-do item to the console
        public void Display()
        {
            int count = 1;
            Console.WriteLine("\nTodos");
            Console.WriteLine(HeaderSymbol);

            foreach (string Todo in Todos)
            {
                if (String.IsNullOrEmpty(Todo))
                {
                    Console.WriteLine($"{count}: []");
                }
                else
                {
                    Console.WriteLine($"{count}: {Todo}");
                }
                count++;
            }

        }
        //Define a Reset() method to satisfy the interface. It should set the Todos property to an empty array of length 5 and set nextOpenIndex to 0.
        public void Reset()
        {
            Todos = new String[5];
            nextOpenIndex = 0;
        }
    }
}

