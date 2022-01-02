using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMG.Chapter3
{
    public static class EventBasedGoals
    {
        public static List<EventBasedGoal> Goals = new();

        static EventBasedGoals()
        {
            Goals.Add(new EventBasedGoal(0, ""));
            Goals.Add(new EventBasedGoal(1, "Bring the villain to justice."));
            Goals.Add(new EventBasedGoal(2, "Clear the name of an innocent NPC."));
            Goals.Add(new EventBasedGoal(3, "Protect or hide an NPC."));
            Goals.Add(new EventBasedGoal(4, "Protect an object."));
            Goals.Add(new EventBasedGoal(5, "Discover the nature and origin of a strange phenomenon that might be the villain's doing."));
            Goals.Add(new EventBasedGoal(6, "Find a wanted fugitive."));
            Goals.Add(new EventBasedGoal(7, "Overthrow a tyrant."));
            Goals.Add(new EventBasedGoal(8, "Uncover a conspiracy to overthrow a ruler."));
            Goals.Add(new EventBasedGoal(9, "Negotiate peace between enemy nations or feuding families."));
            Goals.Add(new EventBasedGoal(10, "Secure aid from a ruler or council."));
            Goals.Add(new EventBasedGoal(11, "Help a villain find redemption."));
            Goals.Add(new EventBasedGoal(12, "Parley with a villain."));
            Goals.Add(new EventBasedGoal(13, "Smuggle weapons to rebel forces."));
            Goals.Add(new EventBasedGoal(14, "Stop a band of smugglers."));
            Goals.Add(new EventBasedGoal(15, "Gather intelligence on an enemy force."));
            Goals.Add(new EventBasedGoal(16, "Win a tournament."));
            Goals.Add(new EventBasedGoal(17, "Determine the villain's identity."));
            Goals.Add(new EventBasedGoal(18, "Locate a stolen item."));
            Goals.Add(new EventBasedGoal(19, "Make sure a wedding goes off without a hitch."));
            Goals.Add(new EventBasedGoal(20, "Roll twice, ignoring results of 20."));
        }
    }
}
