using System;
using System.Collections.Generic;

namespace BoardGameSimulator
{
    // Klasa reprezentująca gracza
    class Player
    {
        public string Name { get; set; }
        public int Position { get; set; }
        public int Points { get; set; }

        public Player(string name)
        {
            Name = name;
            Position = 0; // Startowa pozycja
            Points = 0; // Początkowa liczba punktów
        }

        public void Move(int steps)
        {
            Position += steps;
            Console.WriteLine($"{Name} przesuwa się o {steps} pól na pozycję {Position}.");
        }
    }
}

    