using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMG.Chapter3
{
    public static class MoralQuandaries
    {
        public static List<MoralQuandary> Quandaries = new();

        static MoralQuandaries()
        {
            Quandaries.Add(new MoralQuandary(0, string.Empty));
            Quandaries.Add(new MoralQuandary(1, "Ally quandary"));
            Quandaries.Add(new MoralQuandary(2, "Ally quandary"));
            Quandaries.Add(new MoralQuandary(3, "Ally quandary"));
            Quandaries.Add(new MoralQuandary(4, "Friend quandary"));
            Quandaries.Add(new MoralQuandary(5, "Friend quandary"));
            Quandaries.Add(new MoralQuandary(6, "Friend quandary"));
            Quandaries.Add(new MoralQuandary(7, "Honor quandary"));
            Quandaries.Add(new MoralQuandary(8, "Honor quandary"));
            Quandaries.Add(new MoralQuandary(9, "Honor quandary"));
            Quandaries.Add(new MoralQuandary(10, "Honor quandary"));
            Quandaries.Add(new MoralQuandary(11, "Honor quandary"));
            Quandaries.Add(new MoralQuandary(12, "Honor quandary"));
            Quandaries.Add(new MoralQuandary(13, "Rescue quandary"));
            Quandaries.Add(new MoralQuandary(14, "Rescue quandary"));
            Quandaries.Add(new MoralQuandary(15, "Rescue quandary"));
            Quandaries.Add(new MoralQuandary(16, "Rescue quandary"));
            Quandaries.Add(new MoralQuandary(17, "Respect quandary"));
            Quandaries.Add(new MoralQuandary(18, "Respect quandary"));
            Quandaries.Add(new MoralQuandary(19, "Respect quandary"));
            Quandaries.Add(new MoralQuandary(20, "Respect quandary"));
        }
    }
}
