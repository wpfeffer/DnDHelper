namespace DungeonMastersGuide.Chapter2.PsychicWindEffects;

public static class MentalEffects
{
    public static List<MentalEffect> Effects = new List<MentalEffect>();

    static MentalEffects()
    {
        Effects.Add(new MentalEffect(0, string.Empty));
        Effects.Add(new MentalEffect(1, "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself"));
        Effects.Add(new MentalEffect(2, "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself"));
        Effects.Add(new MentalEffect(3, "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself"));
        Effects.Add(new MentalEffect(4, "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself"));
        Effects.Add(new MentalEffect(5, "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself"));
        Effects.Add(new MentalEffect(6, "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself"));
        Effects.Add(new MentalEffect(7, "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself"));
        Effects.Add(new MentalEffect(8, "Stunned for 1 minute; you can repeat the saving throw at the end of each of your turns to end the effect on yourself"));
        Effects.Add(new MentalEffect(9, "Short-term madness (see chapter 8)"));
        Effects.Add(new MentalEffect(10, "Short-term madness (see chapter 8)"));
        Effects.Add(new MentalEffect(11, "11 (2d10) psychic damage"));
        Effects.Add(new MentalEffect(12, "11 (2d10) psychic damage"));
        Effects.Add(new MentalEffect(13, "22 (4d10) psychic damage"));
        Effects.Add(new MentalEffect(14, "22 (4d10) psychic damage"));
        Effects.Add(new MentalEffect(15, "22 (4d10) psychic damage"));
        Effects.Add(new MentalEffect(16, "22 (4d10) psychic damage"));
        Effects.Add(new MentalEffect(17, "Long-term madness (see chapter 8)"));
        Effects.Add(new MentalEffect(18, "Long-term madness (see chapter 8)"));
        Effects.Add(new MentalEffect(19, "Unconscious for 5 (1d10) minutes; the effect on you ends if you take damage or if another creature uses an action to shake you awake"));
        Effects.Add(new MentalEffect(20, "Unconscious for 5 (1d10) minutes; the effect on you ends if you take damage or if another creature uses an action to shake you awake"));
    }
}
