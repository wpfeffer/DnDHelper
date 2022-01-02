using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMG.Chapter3
{
    public class EventBasedGoal
    {
        private readonly int _roll;
        private readonly string _goal;

        public int Roll => _roll;

        public string Goal => _goal;

        public EventBasedGoal(int roll, string goal)
        {
            _roll = roll;
            _goal = goal;
        }
    }
}
