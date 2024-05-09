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
        public override bool Equals(object obj)
        {
            if (obj == null || GetType()!= obj.GetType())
            {
                return false;
            }

            Player other = (Player)obj;
            return PC == other.PC && Name == other.Name;
        }

        public override int GetHashCode()
        {
            return PC.GetHashCode() ^ Name.GetHashCode();
        }
    }
}