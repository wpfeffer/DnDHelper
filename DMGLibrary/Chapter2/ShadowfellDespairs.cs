namespace DMG.Chapter2;

public static class ShadowfellDespairs
{
    public static List<ShadowfellDespair> Despairs = new();

    static ShadowfellDespairs()
    {
        Despairs.Add(new ShadowfellDespair(0, string.Empty));
        Despairs.Add(new ShadowfellDespair(1, "Apathy. The character has disadvantage on death saving throws and on Dexterity checks for initiative, and gains the following flaw: \"I don't believe I can make a difference to anyone or anything.\""));
        Despairs.Add(new ShadowfellDespair(2, "Apathy. The character has disadvantage on death saving throws and on Dexterity checks for initiative, and gains the following flaw: \"I don't believe I can make a difference to anyone or anything.\""));
        Despairs.Add(new ShadowfellDespair(3, "Apathy. The character has disadvantage on death saving throws and on Dexterity checks for initiative, and gains the following flaw: \"I don't believe I can make a difference to anyone or anything.\""));
        Despairs.Add(new ShadowfellDespair(4, "Dread. The character has disadvantage on all saving throws and gains the following flaw: \"I am convinced that this place is going to kill me.\""));
        Despairs.Add(new ShadowfellDespair(5, "Dread. The character has disadvantage on all saving throws and gains the following flaw: \"I am convinced that this place is going to kill me.\""));
        Despairs.Add(new ShadowfellDespair(6, "Madness. The character has disadvantage on ability checks and saving throws that use Intelligence, Wisdom, or Charisma, and gains the following flaw: \"I can't tell what's real anymore.\""));
    }
}
