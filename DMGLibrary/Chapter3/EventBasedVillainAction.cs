using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMG.Chapter3
{
    public class EventBasedVillainAction
    {
        private readonly int _roll;
        private readonly string _action;

        public int Roll => _roll;

        public string Action => _action;

        public EventBasedVillainAction(int roll, string action)
        {
            _roll = roll;
            _action = action;
        }
    }
}
