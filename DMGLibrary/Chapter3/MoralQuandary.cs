using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMG.Chapter3
{
    public class MoralQuandary
    {
        private readonly int _roll;
        private readonly string _quandary;

        public int Roll => _roll;

        public string Quandary => _quandary;

        public MoralQuandary(int roll, string quandary)
        {
            _roll = roll;
            _quandary = quandary;
        }
    }
}
