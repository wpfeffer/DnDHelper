namespace DMG;

public class NewOrganization
{
    public int Roll { get; set; }
    public string Organization { get; set; }

    public NewOrganization()
    {
        Roll = 0;
        Organization = string.Empty;
    }

    public NewOrganization(int roll, string organization)
    {
        Roll = roll;
        Organization = organization;
    }
}