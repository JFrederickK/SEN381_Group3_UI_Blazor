using SEN381_UI.Data;

namespace SEN381_UI.Data;

public class Package
    {
        string packageID;
        List<PackageTreatmentCoverage> treatmentCoverages;

    public Package()
    {}

    public Package(string packageID, List<PackageTreatmentCoverage> treatmentCoverages)
    {
        this.packageID = packageID;
        this.treatmentCoverages = treatmentCoverages;
    }

    public string PackageID { get => packageID; set => packageID = value; }
    public List<PackageTreatmentCoverage> TreatmentCoverages { get => treatmentCoverages; set => treatmentCoverages = value; }
}

