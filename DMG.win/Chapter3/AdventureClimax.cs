using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMG.Chapter3
{
    public class AdventureClimax
    {
        private readonly int _roll;
        private readonly string _climax;

        public int Roll => _roll;

        public string Climax => _climax;

        public AdventureClimax(int roll, string climax)
        {
            _roll = roll;
            _climax = climax;
        }
    }
}
