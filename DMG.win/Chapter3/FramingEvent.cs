using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMG.Chapter3
{
    public class FramingEvent
    {
        private readonly int _roll;
        private readonly string _framingEvent;

        public int Roll => _roll;

        public string FrameEvent => _framingEvent;

        public FramingEvent(int roll, string framingEvent)
        {
            _roll = roll;
            _framingEvent = framingEvent;
        }
    }
}
