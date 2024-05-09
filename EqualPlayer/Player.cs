using System;
using System.Collections.Generic;

namespace EqualPlayer
{
    public class Player
    {
        public PlayerClass PC { get; }
        public string Name { get; }

        public Player(PlayerClass pClass, string name)
        {
            PC = pClass;
            Name = name;
        }
    }
}