using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMG.Chapter3
{
    public static class FramingEvents
    {
        public static List<FramingEvent> Events = new();

        static FramingEvents()
        {
            Events.Add(new FramingEvent(0, string.Empty));
            Events.Add(new FramingEvent(1, "Anniversary of a monarch's reign"));
            Events.Add(new FramingEvent(2, "Anniversary of a monarch's reign"));
            Events.Add(new FramingEvent(3, "Anniversary of an important event."));
            Events.Add(new FramingEvent(4, "Anniversary of an important event."));
            Events.Add(new FramingEvent(5, "Arena event"));
            Events.Add(new FramingEvent(6, "Arena event"));
            Events.Add(new FramingEvent(7, "Arrival of a caravan or ship"));
            Events.Add(new FramingEvent(8, "Arrival of a caravan or ship"));
            Events.Add(new FramingEvent(9, "Arrival of a circus"));
            Events.Add(new FramingEvent(10, "Arrival of a circus"));
            Events.Add(new FramingEvent(11, "Arrival of an important NPC"));
            Events.Add(new FramingEvent(12, "Arrival of an important NPC"));
            Events.Add(new FramingEvent(13, "Arrival of marching modrons"));
            Events.Add(new FramingEvent(14, "Arrival of marching modrons"));
            Events.Add(new FramingEvent(15, "Artistic performance"));
            Events.Add(new FramingEvent(16, "Artistic performance"));
            Events.Add(new FramingEvent(17, "Athletic event"));
            Events.Add(new FramingEvent(18, "Athletic event"));
            Events.Add(new FramingEvent(19, "Birth of a child"));
            Events.Add(new FramingEvent(20, "Birth of a child"));
            Events.Add(new FramingEvent(21, "Birthday of an important NPC"));
            Events.Add(new FramingEvent(22, "Birthday of an important NPC"));
            Events.Add(new FramingEvent(23, "Civic festival"));
            Events.Add(new FramingEvent(24, "Civic festival"));
            Events.Add(new FramingEvent(25, "Comet appearance"));
            Events.Add(new FramingEvent(26, "Comet appearance"));
            Events.Add(new FramingEvent(27, "Commemoration of a past tragedy"));
            Events.Add(new FramingEvent(28, "Commemoration of a past tragedy"));
            Events.Add(new FramingEvent(29, "Consecration of a new temple"));
            Events.Add(new FramingEvent(30, "Consecration of a new temple"));
            Events.Add(new FramingEvent(31, "Coronation"));
            Events.Add(new FramingEvent(32, "Coronation"));
            Events.Add(new FramingEvent(33, "Council meeting"));
            Events.Add(new FramingEvent(34, "Council meeting"));
            Events.Add(new FramingEvent(35, "Equinox or solstice"));
            Events.Add(new FramingEvent(36, "Equinox or solstice"));
            Events.Add(new FramingEvent(37, "Execution"));
            Events.Add(new FramingEvent(38, "Execution"));
            Events.Add(new FramingEvent(39, "Fertility festival"));
            Events.Add(new FramingEvent(40, "Fertility festival"));
            Events.Add(new FramingEvent(41, "Full moon"));
            Events.Add(new FramingEvent(42, "Full moon"));
            Events.Add(new FramingEvent(43, "Funeral"));
            Events.Add(new FramingEvent(44, "Funeral"));
            Events.Add(new FramingEvent(45, "Graduation of cadets or wizards"));
            Events.Add(new FramingEvent(46, "Graduation of cadets or wizards"));
            Events.Add(new FramingEvent(47, "Harvest festival"));
            Events.Add(new FramingEvent(48, "Harvest festival"));
            Events.Add(new FramingEvent(49, "Holly day"));
            Events.Add(new FramingEvent(50, "Holly day"));
            Events.Add(new FramingEvent(51, "Investiture of a knight or other noble"));
            Events.Add(new FramingEvent(52, "Investiture of a knight or other noble"));
            Events.Add(new FramingEvent(53, "Lunar eclipse"));
            Events.Add(new FramingEvent(54, "Lunar eclipse"));
            Events.Add(new FramingEvent(55, "Midsummer festival"));
            Events.Add(new FramingEvent(56, "Midsummer festival"));
            Events.Add(new FramingEvent(57, "Midsummer festival"));
            Events.Add(new FramingEvent(58, "Midsummer festival"));
            Events.Add(new FramingEvent(59, "Midwinter festival"));
            Events.Add(new FramingEvent(60, "Midwinter festival"));
            Events.Add(new FramingEvent(61, "Migration of monsters"));
            Events.Add(new FramingEvent(62, "Migration of monsters"));
            Events.Add(new FramingEvent(63, "Monarch's ball"));
            Events.Add(new FramingEvent(64, "Monarch's ball"));
            Events.Add(new FramingEvent(65, "New moon"));
            Events.Add(new FramingEvent(66, "New moon"));
            Events.Add(new FramingEvent(67, "New year"));
            Events.Add(new FramingEvent(68, "New year"));
            Events.Add(new FramingEvent(69, "Pardoning of a prisoner"));
            Events.Add(new FramingEvent(70, "Pardoning of a prisoner"));
            Events.Add(new FramingEvent(71, "Planar conjunction"));
            Events.Add(new FramingEvent(72, "Planar conjunction"));
            Events.Add(new FramingEvent(73, "Planetary alignment"));
            Events.Add(new FramingEvent(74, "Planetary alignment"));
            Events.Add(new FramingEvent(75, "Priestly investiture"));
            Events.Add(new FramingEvent(76, "Priestly investiture"));
            Events.Add(new FramingEvent(77, "Procession of ghosts"));
            Events.Add(new FramingEvent(78, "Procession of ghosts"));
            Events.Add(new FramingEvent(79, "Remembrance for soldiers lost in war"));
            Events.Add(new FramingEvent(80, "Remembrance for soldiers lost in war"));
            Events.Add(new FramingEvent(81, "Royal address or proclamation"));
            Events.Add(new FramingEvent(82, "Royal address or proclamation"));
            Events.Add(new FramingEvent(83, "Royal audience day"));
            Events.Add(new FramingEvent(84, "Royal audience day"));
            Events.Add(new FramingEvent(85, "Signing of a treaty"));
            Events.Add(new FramingEvent(86, "Signing of a treaty"));
            Events.Add(new FramingEvent(87, "Solar eclipse"));
            Events.Add(new FramingEvent(88, "Solar eclipse"));
            Events.Add(new FramingEvent(89, "Tournament"));
            Events.Add(new FramingEvent(90, "Tournament"));
            Events.Add(new FramingEvent(91, "Tournament"));
            Events.Add(new FramingEvent(92, "Trial"));
            Events.Add(new FramingEvent(93, "Trial"));
            Events.Add(new FramingEvent(94, "Trial"));
            Events.Add(new FramingEvent(95, "Violent uprising"));
            Events.Add(new FramingEvent(96, "Violent uprising"));
            Events.Add(new FramingEvent(97, "Wedding or wedding anniversary"));
            Events.Add(new FramingEvent(98, "Wedding or wedding anniversary"));
            Events.Add(new FramingEvent(99, "Concurrence of two events (roll twice, ignoring results of 99 or 100)"));
            Events.Add(new FramingEvent(100, "Concurrence of two events (roll twice, ignoring results of 99 or 100)"));
        }
    }
}
