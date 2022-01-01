using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMastersGuide.Chapter3
{
    public class AdventurePatron
    {
        private readonly int _roll;
        private readonly string _patron;

        public int Roll => _roll;

        public string Patron => _patron;

        public AdventurePatron(int roll, string patron)
        {
            _roll = roll;
            _patron = patron;
        }
    }
}
