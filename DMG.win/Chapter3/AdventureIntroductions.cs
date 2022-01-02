using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMG.Chapter3
{
    public static class AdventureIntroductions
    {
        public static List<AdventureIntroduction> Introductions = new();

        static AdventureIntroductions()
        {
            Introductions.Add(new AdventureIntroduction(0, string.Empty));
            Introductions.Add(new AdventureIntroduction(1, "While traveling in the wilderness, the characters fall into a sinkhole that opens beneath their feet, dropping them into the adventure location."));
            Introductions.Add(new AdventureIntroduction(2, "While traveling in the wilderness, the characters notice the entrance to the adventure location."));
            Introductions.Add(new AdventureIntroduction(3, "While traveling on a road, the characters are attacked by monsters that flee into the nearby adventure location."));
            Introductions.Add(new AdventureIntroduction(4, "The adventurers find a map on a dead body. In addition to the map setting up the adventure, the adventure's villain wants the map."));
            Introductions.Add(new AdventureIntroduction(5, "A mysterious magic item or a cruel villain teleports the characters to the adventure location."));
            Introductions.Add(new AdventureIntroduction(6, "A stranger approaches the characters in a tavern and urges them toward the adventure location."));
            Introductions.Add(new AdventureIntroduction(7, "A town or village needs volunteers to go to the adventure location."));
            Introductions.Add(new AdventureIntroduction(8, "An NPC the characters respect asks them to go to the adventure location."));
            Introductions.Add(new AdventureIntroduction(9, "An NPC the characters must obey orders them to go to the adventure location."));
            Introductions.Add(new AdventureIntroduction(10, "An NPC the characters respect asks them to go to the adventure location."));
            Introductions.Add(new AdventureIntroduction(11, "One night, the characters all dream about entering the adventure location."));
            Introductions.Add(new AdventureIntroduction(12, "A ghost appears and terrorizes a village. Research reveals that it can be put to rest only by entering the adventure location."));
        }
    }
}
