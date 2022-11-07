namespace SEN381_UI.Data;

public class FamilyClient : Client
{
    private FamilyMember[]? familyMembers;

    public FamilyClient(string clientID, string clientName, string clientSurname, string clientAddress, string clientEmail, string clientPhoneNumber, ClientPolicy policies, string clientStatus, string clientAdHocNotes, FamilyMember[]? familyMembers) : base(clientID, clientName, clientSurname, clientAddress, clientEmail, clientPhoneNumber, policies, clientStatus, clientAdHocNotes)
    {
        FamilyMembers = familyMembers;
    }

    public FamilyMember[]? FamilyMembers { get => familyMembers; set => familyMembers = value; }
}