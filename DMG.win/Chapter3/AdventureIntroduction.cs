using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMG.Chapter3
{
    public class AdventureIntroduction
    {
        private readonly int _roll;
        private readonly string _introduction;

        public int Roll => _roll;

        public string Introduction => _introduction;

        public AdventureIntroduction(int roll, string introduction)
        {
            _roll = roll;
            _introduction = introduction;
        }
    }
}
