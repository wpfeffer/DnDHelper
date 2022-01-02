using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMG.Chapter3
{
    public static class AdventureClimaxes
    {
        public static List<AdventureClimax> Climaxes = new();

        static AdventureClimaxes()
        {
            Climaxes.Add(new AdventureClimax(0, string.Empty));
            Climaxes.Add(new AdventureClimax(1, "The adventurers confront the main villain and a group of minions in a bloody battle to the finish."));
            Climaxes.Add(new AdventureClimax(2, "The adventurers chase the villain while dodging obstacles designed to thwart them, leading to a final confrontation in or outside the villain's refuge."));
            Climaxes.Add(new AdventureClimax(3, "The actions of the adventurers or the villain result in a cataclysmic event that the adventurers must escape."));
            Climaxes.Add(new AdventureClimax(4, "The adventurers race tot he site where the villain is bringing a master plan to its conclusion, arriving just as that plan is about to be completed."));
            Climaxes.Add(new AdventureClimax(5, "The villain and two or three lieutenants perform separate rites in a large room. The adventurers must disrupt all the rites at the same time."));
            Climaxes.Add(new AdventureClimax(6, "An ally betrays the adventurers as they're about to achieve their goal. (Use this climax carefully, and don't overuse it.)"));
            Climaxes.Add(new AdventureClimax(7, "A portal opens to another plane of existence. Creatures on the other side spill out, forcing the adventurers to close the portal and deal with the villain at the same time."));
            Climaxes.Add(new AdventureClimax(8, "Traps, hazards, or animated objects turn against the adventurers while the main villain attacks."));
            Climaxes.Add(new AdventureClimax(9, "The dungeon begins to collapse while the adventurers face the main villain, who attempts to escape in the chaos."));
            Climaxes.Add(new AdventureClimax(10, "A threat more powerful than the adventurers appears, destroys the main villain, and then turns its attention on the characters."));
            Climaxes.Add(new AdventureClimax(11, "The adventurers must choose whether to pursue the fleeing main villain or save an NPC they care about or a group of innocents."));
            Climaxes.Add(new AdventureClimax(12, "The adventurers must discover the main villain's secret weakness before they can hope to defeat that villain."));
        }
    }
}
