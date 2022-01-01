namespace DungeonMastersGuide.Chapter2.PsychicWindEffects
{
    public static class LocationEffects
    {
        public static List<LocationEffect> Effects = new List<LocationEffect>();

        static LocationEffects()
        {
            Effects.Add(new LocationEffect(0, string.Empty));
            Effects.Add(new LocationEffect(1, "Diverted; add 1d6 hours to travel time"));
            Effects.Add(new LocationEffect(2, "Diverted; add 1d6 hours to travel time"));
            Effects.Add(new LocationEffect(3, "Diverted; add 1d6 hours to travel time"));
            Effects.Add(new LocationEffect(4, "Diverted; add 1d6 hours to travel time"));
            Effects.Add(new LocationEffect(5, "Diverted; add 1d6 hours to travel time"));
            Effects.Add(new LocationEffect(6, "Diverted; add 1d6 hours to travel time"));
            Effects.Add(new LocationEffect(7, "Diverted; add 1d6 hours to travel time"));
            Effects.Add(new LocationEffect(8, "Diverted; add 1d6 hours to travel time"));
            Effects.Add(new LocationEffect(9, "Blown off course; add 3d10 hours to travel time"));
            Effects.Add(new LocationEffect(10, "Blown off course; add 3d10 hours to travel time"));
            Effects.Add(new LocationEffect(11, "Blown off course; add 3d10 hours to travel time"));
            Effects.Add(new LocationEffect(12, "Blown off course; add 3d10 hours to travel time"));
            Effects.Add(new LocationEffect(13, "Lost; at the end of the travel time, characters arrive at a location other than the intended destination"));
            Effects.Add(new LocationEffect(14, "Lost; at the end of the travel time, characters arrive at a location other than the intended destination"));
            Effects.Add(new LocationEffect(15, "Lost; at the end of the travel time, characters arrive at a location other than the intended destination"));
            Effects.Add(new LocationEffect(16, "Lost; at the end of the travel time, characters arrive at a location other than the intended destination"));
            Effects.Add(new LocationEffect(17, "Sent through color pool to a random plane (roll on the Astral Color Pools table)"));
            Effects.Add(new LocationEffect(18, "Sent through color pool to a random plane (roll on the Astral Color Pools table)"));
            Effects.Add(new LocationEffect(19, "Sent through color pool to a random plane (roll on the Astral Color Pools table)"));
            Effects.Add(new LocationEffect(20, "Sent through color pool to a random plane (roll on the Astral Color Pools table)"));
        }
    }
}