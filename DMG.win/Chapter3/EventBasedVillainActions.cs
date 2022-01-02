using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMG.Chapter3
{
    public static class EventBasedVillainActions
    {
        public static List<EventBasedVillainAction> Actions = new();

        static EventBasedVillainActions()
        {
            Actions.Add(new EventBasedVillainAction(0, string.Empty));
            Actions.Add(new EventBasedVillainAction(1, "Big Event"));
            Actions.Add(new EventBasedVillainAction(2, "Crime Spree"));
            Actions.Add(new EventBasedVillainAction(3, "Growing Corruption"));
            Actions.Add(new EventBasedVillainAction(4, "One and Done"));
            Actions.Add(new EventBasedVillainAction(5, "Serial Crimes"));
            Actions.Add(new EventBasedVillainAction(6, "Step by Step"));
        }
    }
}
