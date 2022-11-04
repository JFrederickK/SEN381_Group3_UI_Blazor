using SEN381_UI.Data;

namespace SEN381_UI.Data;

public class Package
    {
    private string packageID;
    private List<PackageTreatmentCoverage> treatmentCoverages;
    private DateTime? packageStartDate;
    private DateTime? packageEndDate;

    public Package()
    { }

    public Package(string packageID, DateTime? packageStartDate, DateTime? packageEndDate, List<PackageTreatmentCoverage> treatmentCoverages)
    {
        this.packageID = packageID;
        this.treatmentCoverages = treatmentCoverages;
        this.packageStartDate = packageStartDate;
        this.packageEndDate = packageEndDate;
    }

    public string PackageID { get => packageID; set => packageID = value; }
    public List<PackageTreatmentCoverage> TreatmentCoverages { get => treatmentCoverages; set => treatmentCoverages = value; }
    public DateTime? PackageStartDate { get => packageStartDate; set => packageStartDate = value; }
    public DateTime? PackageEndDate { get => packageEndDate; set => packageEndDate = value; }
}

