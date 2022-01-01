using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMastersGuide.Chapter3
{
    public static class AdventureAllies
    {
        public static List<AdventureAlly> Allies = new();

        static AdventureAllies()
        {
            Allies.Add(new AdventureAlly(0, string.Empty));
            Allies.Add(new AdventureAlly(1, "Skilled adventurer"));
            Allies.Add(new AdventureAlly(2, "Inexperienced adventurer"));
            Allies.Add(new AdventureAlly(3, "Enthusiastic commoner"));
            Allies.Add(new AdventureAlly(4, "Soldier"));
            Allies.Add(new AdventureAlly(5, "Priest"));
            Allies.Add(new AdventureAlly(6, "Sage"));
            Allies.Add(new AdventureAlly(7, "Revenge seeker"));
            Allies.Add(new AdventureAlly(8, "Raving lunatic"));
            Allies.Add(new AdventureAlly(9, "Celestial ally"));
            Allies.Add(new AdventureAlly(10, "Fey ally"));
            Allies.Add(new AdventureAlly(11, "Disguised monster"));
            Allies.Add(new AdventureAlly(12, "Villain posing as an ally"));
        }
    }
}
