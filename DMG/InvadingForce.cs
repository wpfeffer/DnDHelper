namespace DMG
{
    public class InvadingForce
    {
        public int Roll { get; set; }
        public string Force { get; set; }

        public InvadingForce()
        {
            Roll = 0;
            Force = string.Empty;
        }

        public InvadingForce(int roll, string force)
        {
            Roll = roll;
            Force = force;
        }
    }
}
