namespace SEN381_UI.Data;

public class Package
{
    string packageID;
    string treatment;
    private string st;



    public string PackageID { get => packageID; set => packageID = value; }
    public string Treatment { get => treatment; set => treatment = value; }
    public string St { get => st; set => st = value; }



    public Package(string packageID, string treatment, string st)
    {
        PackageID = packageID;
        Treatment = treatment;
        St = st;
    }
}